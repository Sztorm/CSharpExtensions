#### [Sztorm.Extensions](./index.md 'index')
### [Sztorm.Extensions.Enum](./Sztorm-Extensions-Enum.md 'Sztorm.Extensions.Enum').[EnumExtensions](./Sztorm-Extensions-Enum-EnumExtensions.md 'Sztorm.Extensions.Enum.EnumExtensions')
## EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool) Method
Returns [source](#Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-source 'Sztorm.Extensions.Enum.EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool).source') enum with specified [flags](#Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-flags 'Sztorm.Extensions.Enum.EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool).flags') set  
to [value](#Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-value 'Sztorm.Extensions.Enum.EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool).value').<br />  
Supported enum sizes are 1, 2, 4 and 8-byte.  



    Exceptions:<br />[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') Size of underlying enum type is not supported.  
```csharp
public static TEnum WithFlagsSetTo<TEnum>(this TEnum source, TEnum flags, bool value);
```
#### Type parameters
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-TEnum'></a>
`TEnum`  
  
  
#### Parameters
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-source'></a>
`source` [TEnum](#Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool).TEnum')  
  
  
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-flags'></a>
`flags` [TEnum](#Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool).TEnum')  
  
  
<a name='Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-value'></a>
`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
  
#### Returns
[TEnum](#Sztorm-Extensions-Enum-EnumExtensions-WithFlagsSetTo-TEnum-(TEnum_TEnum_bool)-TEnum 'Sztorm.Extensions.Enum.EnumExtensions.WithFlagsSetTo&lt;TEnum&gt;(TEnum, TEnum, bool).TEnum')  
  
