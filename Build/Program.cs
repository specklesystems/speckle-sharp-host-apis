using Build;
using GlobExpressions;
using static Bullseye.Targets;
using static SimpleExec.Command;

const string CLEAN = "clean";
const string RESTORE = "restore";
const string BUILD = "build";
const string TEST = "test";
const string FORMAT = "format";
const string RESTORE_TOOLS = "restore-tools";
const string PACK = "pack";

Target(
  CLEAN,
  ForEach("**/output"),
  dir =>
  {
    IEnumerable<string> GetDirectories(string d)
    {
      return Glob.Directories(".", d);
    }

    void RemoveDirectory(string d)
    {
      if (Directory.Exists(d))
      {
        Console.WriteLine(d);
        Directory.Delete(d, true);
      }
    }

    foreach (var d in GetDirectories(dir))
    {
      RemoveDirectory(d);
    }
  }
);

Target(
  RESTORE_TOOLS,
  () =>
  {
    Run("dotnet", "tool restore");
  }
);

Target(
  FORMAT,
  DependsOn(RESTORE_TOOLS),
  () =>
  {
    Run("dotnet", "csharpier --check .");
  }
);

Target(
  RESTORE,
  Consts.Solutions,
  s =>
  {
    Run("dotnet", $"restore {s} --locked-mode");
  }
);

Target(
  BUILD,
  DependsOn(RESTORE),
  Consts.Solutions,
  s =>
  {
    Run("dotnet", $"build {s} -c Release --no-restore");
  }
);

Target(
  TEST,
  DependsOn(BUILD),
  () =>
  {
    IEnumerable<string> GetFiles(string d)
    {
      return Glob.Files(".", d);
    }

    foreach (var file in GetFiles("**/*.Test.csproj"))
    {
      Run("dotnet", $"test {file} -c Release --no-restore --verbosity=normal");
    }
  }
);

Target(
  PACK,
  DependsOn(TEST),
  Consts.Solutions,
  s =>
  {
    Run("dotnet", $"pack {s} -c Release -o output --no-build");
  }
);

Target("default", DependsOn(FORMAT, TEST), () => Console.WriteLine("Done!"));

await RunTargetsAndExitAsync(args).ConfigureAwait(true);
