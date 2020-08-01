using Quantify.Repository.Enum.DataAnnotation;

namespace Quantify.Length
{
    public enum Unit
    {
        // Length - SI
        [Unit("0.000000000000000000000001")]
        Yoctometre = 10,
        [Unit("0.000000000000000000001")]
        Zeptometre = 11,
        [Unit("0.000000000000000001")]
        Attometre = 12,
        [Unit("0.000000000000001")]
        Femtometre = 13,
        [Unit("0.000000000001")]
        Picometre = 14,
        [Unit("0.000000001")]
        Nanometre = 15,
        [Unit("0.000001")]
        Micrometre = 16,
        [Unit("0.001")]
        Millimetre = 17,
        [Unit("0.01")]
        Centimetre = 18,
        [Unit("0.1")]
        Decimetre = 19,
        [BaseUnit]
        Metre = 20,
        [Unit("10")]
        Decametre = 21,
        [Unit("100")]
        Hectometre = 22,
        [Unit("1000")]
        Kilometre = 23,
        [Unit("1000000")]
        Megametre = 24,
        [Unit("1000000000")]
        Gigametre = 25,
        [Unit("1000000000000")]
        Terametre = 26,
        [Unit("1000000000000000")]
        Petametre = 27,
        [Unit("1000000000000000000")]
        Exametre = 28,
        [Unit("1000000000000000000000")]
        Zettametre = 29,
        [Unit("1000000000000000000000000")]
        Yottametre = 30,

        // Length - Imperial
        [Unit("0.000000352778")]
        Point = 50,
        [Unit("0.004233")]
        Pica = 51,
        [Unit("0.0000254")]
        Thou = 52,
        [Unit("0.0254")]
        Inch = 53,
        [Unit("0.3048")]
        Foot = 54,
        [Unit("0.9144")]
        Yard = 55,
        [Unit("20.1168")]
        Chain = 56,
        [Unit("201.168")]
        Furlong = 57,
        [Unit("1609.344")]
        Mile = 58,
        [Unit("4828.032")]
        League = 59,
        [Unit("1.852")]
        Fathom = 60,
        [Unit("185.2")]
        Cable = 61,
        [Unit("1852")]
        NauticalMile = 62,
        [Unit("0.201168")]
        Link = 63,
        [Unit("5.0292")]
        Rod = 64

        // Length - Astronomical Units
    }
}