namespace Rhino.DocObjects;

public enum InstanceDefinitionArchiveFileStatus
{
  NotALinkedInstanceDefinition,
  LinkedFileNotReadable,
  LinkedFileNotFound,
  LinkedFileIsUpToDate,
  LinkedFileIsNewer,
  LinkedFileIsOlder,
  LinkedFileIsDifferent,
}
