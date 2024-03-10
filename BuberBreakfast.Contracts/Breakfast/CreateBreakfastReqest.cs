namespace BuberBreakfast.Contracts.BuberBreakfast;

public record CreateBreakfastRequest(
  string Name,
  string Description,
  DateTime StartDateTime,
  DateTime EndDateTme,
  List<string> Savory,
  List<string> Sweet);
