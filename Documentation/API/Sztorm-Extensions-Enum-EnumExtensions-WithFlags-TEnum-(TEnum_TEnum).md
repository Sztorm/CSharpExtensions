### [Sztorm.Extensions.Enum](./Sztorm-Extensions-Enum.md 'Sztorm.Extensions.Enum').[EnumExtensions](./Sztorm-Extensions-Enum-EnumExtensions.md 'Sztorm.Extensions.Enum.EnumExtensions')
## EnumExtensions.WithFlags&lt;TEnum&gt;(TEnum, TEnum) Method
Returns [source](#Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-source 'Sztorm.Extensions.Enum.EnumExtensions.WithFlags&lt;TEnum&gt;(TEnum, TEnum).source') enum with specified [flags](#Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-flags 'Sztorm.Extensions.Enum.EnumExtensions.WithFlags&lt;TEnum&gt;(TEnum, TEnum).flags').  
<br />  
Supported enum sizes are 1, 2, 4 and 8-byte.  



    Exceptions:<br />[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') Size of underlying enum type is not supported.  
```csharp
public static TEnum WithFlags<TEnum>(this TEnum source, TEnum flags);
```
#### Type parameters
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-TEnum'></a>
`TEnum`  
  
  
#### Parameters
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-source'></a>
`source` [TEnum](#Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.WithFlags&lt;TEnum&gt;(TEnum, TEnum).TEnum')  
  
  
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-flags'></a>
`flags` [TEnum](#Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.WithFlags&lt;TEnum&gt;(TEnum, TEnum).TEnum')  
  
  
#### Returns
[TEnum](#Sztorm-Extensions-Enum-EnumExtensions-WithFlags-TEnum-(TEnum_TEnum)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.WithFlags&lt;TEnum&gt;(TEnum, TEnum).TEnum')  
  
