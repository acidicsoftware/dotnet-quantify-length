# Quantify.Length

Quantify.Length makes it easy to work with lengths, when multiple units are in play.

```csharp
var lengthInKilometers = Length.Create(11.2, Unit.Kilometre);
var lengthInMiles = Length.Create(5, Unit.Mile);

var totalLengthInKilometers = lengthInKilometers + lengthInMiles;
```

For more information about how quantities works and what features are available, please see [Quantify](https://github.com/acidicsoftware/dotnet-quantify).

## Length and PreciseLength

Quantify.Length contains two different class for working with lengths.

In [Length](src/Quantify.Length/Length.cs) the quantity value is stored as a `double`. This means that the class is optimised towards performance. As a result of this round-off errors might occur.

In [PreciseLength](src/Quantify.PreciseLength/PreciseLength.cs) the quantity value is stored as a `decimal`, which is optimized towards precision. The consequence of this is a slight performance hit when doing calculations.

## Supported Units

The following unit are supported in the latest version of the library.

| SI | Imperial | Typographic  (Planned) | Astronomical (Planned) |
| :--- | :--- | :--- | :--- |
| Yoctometre | Thou | |
| Zeptometre | Inch | |
| Attometre | Foot | |
| Femtometre | Yard | |
| Picometre | Chain | |
| Nanometre | Furlong | |
| Micrometre | Mile | |
| Millimetre | League | |
| Centimetre | Fathom | |
| Decimetre | Cable | |
| Metre | NauticalMile | |
| Decametre | Link | |
| Hectometre | Rod | |
| Kilometre | | |
| Megametre | | |
| Gigametre | | |
| Terametre | | |
| Petametre | | |
| Exametre | | |
| Zettametre | | |
| Yottametre | | |

See [Unit](src/Quantify.Length/Unit.cs) for more details. 