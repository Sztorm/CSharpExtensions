### [Sztorm.Extensions.Enum](./Sztorm-Extensions-Enum.md 'Sztorm.Extensions.Enum').[EnumExtensions](./Sztorm-Extensions-Enum-EnumExtensions.md 'Sztorm.Extensions.Enum.EnumExtensions')
## EnumExtensions.HasAllFlags&lt;TEnum&gt;(TEnum, TEnum) Method
Returns value indicating whether all the [flags](#Sztorm-Extensions-Enum-EnumExtensions-HasAllFlags-TEnum-(TEnum_TEnum)-flags 'Sztorm.Extensions.Enum.EnumExtensions.HasAllFlags&lt;TEnum&gt;(TEnum, TEnum).flags') are set in the  
current instance. Always returns https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/true for flags whose underlying  
value is zero.<br />  
Supported enum sizes are 1, 2, 4 and 8-byte.  



    Exceptions:<br />[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') Size of underlying enum type is not supported.  
```csharp
public static bool HasAllFlags<TEnum>(this TEnum source, TEnum flags);
```
#### Type parameters
<a name='Sztorm-Extensions-Enum-EnumExtensions-HasAllFlags-TEnum-(TEnum_TEnum)-TEnum'></a>
`TEnum`  
  
  
#### Parameters
<a name='Sztorm-Extensions-Enum-EnumExtensions-HasAllFlags-TEnum-(TEnum_TEnum)-source'></a>
`source` [TEnum](#Sztorm-Extensions-Enum-EnumExtensions-HasAllFlags-TEnum-(TEnum_TEnum)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.HasAllFlags&lt;TEnum&gt;(TEnum, TEnum).TEnum')  
  
  
<a name='Sztorm-Extensions-Enum-EnumExtensions-HasAllFlags-TEnum-(TEnum_TEnum)-flags'></a>
`flags` [TEnum](#Sztorm-Extensions-Enum-EnumExtensions-HasAllFlags-TEnum-(TEnum_TEnum)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.HasAllFlags&lt;TEnum&gt;(TEnum, TEnum).TEnum')  
  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
