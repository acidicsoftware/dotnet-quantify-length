using Quantify.Repository.Enum.DataAnnotation;

namespace Quantify.Length
{
    /// <summary>
    /// Units representing lengths.
    /// </summary>
    [BaseUnit(Unit.Metre)]
    public enum Unit
    {
        // SI Units
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

        // Imperial Unit  
        [Unit("0.0000254")]
        Thou = 50,
        [Unit("0.0254")]
        Inch = 51,
        [Unit("0.3048")]
        Foot = 52,
        [Unit("0.9144")]
        Yard = 53,
        [Unit("20.1168")]
        Chain = 54,
        [Unit("201.168")]
        Furlong = 55,
        [Unit("1609.344")]
        Mile = 56,
        [Unit("4828.032")]
        League = 57,
        [Unit("1.852")]
        Fathom = 58,
        [Unit("185.2")]
        Cable = 59,
        [Unit("1852")]
        NauticalMile = 60,
        [Unit("0.201168")]
        Link = 61,
        [Unit("5.0292")]
        Rod = 62,

        // Astronomical Units
        [Unit("149597870700")]
        AstronomicalUnit = 100,
        [Unit("384402000")]
        LunarDistance = 101,
        [Unit("30857000000000000")]
        Parsec = 110,
        [Unit("30857000000000000000")]
        KiloParsec = 111,
        [Unit("30857000000000000000000")]
        MegaParsec = 112,
        [Unit("30857000000000000000000000")]
        GigaParsec = 113,
        [Unit("9460700000000000")]
        LightYear = 120,
        [Unit("9460700000000000000")]
        KiloLightYear = 121,
        [Unit("9460700000000000000000")]
        MegaLightYear = 122,
        [Unit("9460700000000000000000000")]
        GigaLightYear = 123


        // Typography
        //[Unit("0.000000352778")]
        //Point = 100,
        //[Unit("0.004233")]
        //Pica = 101
    }
}