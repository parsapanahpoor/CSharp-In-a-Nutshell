# Properties - Quick Review

## Definition
A property is a mechanism for accessing class data using accessors (`get` and `set`) that provide encapsulation and access control.

## Usage
- Encapsulating private fields
- Validating values before setting
- Executing custom logic when accessing or setting
- Providing safe public interface for data
- Converting values or performing calculations on-demand

## Key Points
- **Auto Properties**: Short syntax `{ get; set; }` without backing field
- **Backing Field**: Private field behind property to store value
- **Get Accessor**: Responsible for returning property value
- **Set Accessor**: Responsible for setting property value
- **Access Modifiers**: Can have different access modifiers for get and set
- **Read-only Property**: Only getter without setter
- **Write-only Property**: Only setter without getter (rare)
- **Expression-bodied Property**: Short syntax with `=>` (C# 6+)
- **Init-only Property**: `{ get; init; }` for setting only during initialization (C# 9+)
- **Required Properties**: With `required` keyword must be initialized (C# 11+)
- **Property Validation**: Validation in setter
- **Lazy Initialization**: Computing value on-demand
- **Computed Properties**: Computing value based on other fields
- **Indexed Properties**: Indexer for accessing collection elements
