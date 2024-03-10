namespace BuberBreakfast.Contracts.BuberBreakfast;

public record BreakfastResponse(
  Guid Id,
  string Name,
  string Description,
  DateTime StartDateTime,
  DateTime EndDateTme,
  DateTime LastModifiedDateTime,
  List<string> Savory,
  List<string> Sweet);
