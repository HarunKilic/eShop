using eShop.Core.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.DataStore;

public class ProductRepository : IProductRepository
{
    private List<Product> products;

    public ProductRepository()
    {
        products = new List<Product>
        {
            new()
            {
                ProductId = 495, Brand = "maybelline", Name = "Maybelline Face Studio Master Hi-Light Light Booster Bronzer",
                Price = 14.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/991799d3e70b8856686979f8ff6dcfe0_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline Face Studio Master Hi-Light Light Boosting bronzer formula has an expert  balance of shade + shimmer illuminator for natural glow. Skin goes  soft-lit with zero glitz.    For Best Results: Brush over all shades in palette and gently sweep over  cheekbones, brow bones, and temples, or anywhere light naturally touches  the face.                            "
            },
            new()
            {
                ProductId = 488, Brand = "maybelline", Name = "Maybelline Fit Me Bronzer", Price = 10.29,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/d4f7d82b4858c622bb3c1cef07b9d850_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Why You'll Love It  Lightweight pigments blend easily and wear evenly Provides a natural, fade-proof bronzed color that leaves skin the way it was meant to be...fresh, breathing and natural  For Best Results: For soft, natural look, brush along cheekbone, sweeping upward."
            },
            new()
            {
                ProductId = 477, Brand = "maybelline", Name = "Maybelline Facestudio Master Contour Kit", Price = 15.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/4f731de249cbd4cb819ea7f5f4cfb5c3_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline Facestudio Master Contour Kit is the ultimate on the go all-in-one palette, with contouring brush included.  Define and highlight in a New York minute with this effortless 3-step face contouring kit.  This easy-to-use 3-step face contouring kit features a bronzer, blush and highlighter."
            },
            new()
            {
                ProductId = 468, Brand = "maybelline", Name = "Maybelline Face Studio Master Hi-Light Light Booster Blush",
                Price = 14.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/4621032a92cb428ad640c105b944b39c_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline Face Studio Master Hi-Light Light Boosting blush formula has an expert  balance of shade + shimmer illuminator for natural glow. Skin goes  soft-lit with zero glitz.    For Best Results: Brush over all shades in palette and gently sweep over  cheekbones, brow bones, and temples, or anywhere light naturally touches  the face.                            "
            },
            new()
            {
                ProductId = 439, Brand = "maybelline", Name = "Maybelline Fit Me Blush", Price = 10.29,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/53d5f825461117c0d96946e1029510b0_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline Fit Me Blush has lightweight pigments blend easily and wear evenly. It provides a natural, fade-proof cheek color that leaves skin the way it was meant to be...fresh, breathing, and natural.  For Best Results: For soft, natural look, brush along cheekbone, sweeping upward."
            },

            new()
            {
                ProductId = 414, Brand = "maybelline", Name = "Maybelline Dream Bouncy Blush", Price = 11.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/51eacb9efebbaee39399e65ffe3d9416_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Now, blush has bounce! Freshest flush ever:• New bouncy texture is formulated with silicone elastomers• Lightweight like a powder, yet melts seamlessly into skin like a cream giving you a fresh flush• Dermatologist tested• Allergy tested• Non-comedogenic                                                                                                                 For best results: With your fingertips, blend a small amount of  blush onto the apples of your cheeks, applying from your cheekbones to  your temples. To build colour intensity, apply more blush.                      "
            },
            new()
            {
                ProductId = 380, Brand = "maybelline", Name = "Maybelline Fit Me Shine-Free Foundation Stick", Price = 10.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/d04e7c2ed65dabe1dca4eed9aa268e95_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Get flawless, shine-free skin instantly and on-the-go for tailor-made  mattifying coverage.  The anti-shine core has ultra-lightweight powders  built in to the stick foundation to instantly dissolve excess oil. Features: Maybelline's first gel stick foundation with an anti-shine core Fresh gel foundation blends to a flawless matte finish Lightweight powders in the anti-shine core instantly dissolve excess oil"
            },
            new()
            {
                ProductId = 379, Brand = "maybelline", Name = "Maybelline Dream Matte Mousse Foundation", Price = 14.79,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/029889b345c76a70e8bb978b73ed1a87_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline Dream Matte Mouse Foundation is a revolutionary air-soft mousse that provides perfecting coverage for 100% velvet-matte complexion. It's non-comedogenic, fragrance-free, dermatologist-tested, allergy-tested and ideal for normal to oily skin.For best results: Apply smoothly and evenly to your face and blend with your fingertips.﻿   "
            },
            new()
            {
                ProductId = 366, Brand = "maybelline", Name = "Maybelline Mineral Power Natural Perfecting Powder Foundation",
                Price = 14.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/c77ad2da76259cfd67a9a9432f635bfb_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Why You'll Love ItMineral Power Powder Foundation with micro-minerals provides a more natural, healthier, luminous look. Discover the natural power of micro-minerals: 100% natural mica creates a more natural luminosity Complete, yet refined coverage Provides buildable, even coverage Preservative-free, talc-free, oil-free, fragrance-free Medium to Full Coverage"
            },
            new()
            {
                ProductId = 354, Brand = "maybelline", Name = "Maybelline Dream Velvet Foundation", Price = 18.49,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/24517c6c81c92eda31cd32b6327c1298_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "This Maybelline Dream Velvet Foundation is a refreshing gel-whipped foundation that leaves complexion perfected and smooth with a velvety, soft-matte finish. Skin stays hydrated for 12 hours. Features:Maybelline’s first hydrating matte foundation for 100% velvet-smooth perfectionUnique gel-whipped formulaProductIdeal for normal to combination skin, medium coverage For best results apply Maybelline Dream Velvet Foundation using Maybelline Dream Blender"
            },
            new()
            {
                ProductId = 353, Brand = "maybelline", Name = "Maybelline Superstay Better Skin Foundation", Price = 14.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/c7d967ef502ecd79ab7ab466c4952d82_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "The Maybelline Superstay Better Skin Foundation reduces the appearance of spots, bumps, dullness and redness to give you brighter, smoother and more even skin. Features:Longwear that improves skin every minute you're in it: brighter, smoother and more even.With micro-flex technology and the antioxidant power of Actyl-C.ProductIdeal for sensitive skin. Good for all skin types. Medium to full coverageHow to Apply: Apply evenly to your face and blend with your fingers. "
            },
            new()
            {
                ProductId = 339, Brand = "maybelline", Name = "Maybelline Dream Wonder Liquid Touch Foundation", Price = 14.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/ccb99ad6ac7f31a2a73454bdbda01d99_ra,w158,h184_pa,w158,h184.jpeg",
                Description =
                    "Maybelline Dream Wonder Liquid Touch Foundation's breakthrough texture fuses with skin. A finish so impeccable, yet undetectable.Features:Exclusive dropperMedium to full coverage, ideal for normal skinFor Best Results: Shake well. Unscrew cap. Holding dropper vertically, allow foundation to drop onto fingertip. Apply to face as usual."
            },
            new()
            {
                ProductId = 321, Brand = "maybelline", Name = "Maybelline Dream Liquid Mousse", Price = 14.79,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/1ca6a4a442b9aa6b5f3d94da77d8846c_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Airbrushed perfection made possible:Air-whipped liquid makeup for 100% poreless skin  Breakthrough finish cushions and smooths for the most flawless, luminous coverage Lightweight air-whipped formula blends to virtually eliminate pores and imperfections Innovative shade-match pump makes finding your perfect shade a dream  "
            },
            new()
            {
                ProductId = 320, Brand = "maybelline", Name = "Maybelline FIT ME! Matte + Poreless Foundation", Price = 10.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/257993e12625cc45a72ec03636ffa5c5_ra,w158,h184_pa,w158,h184.jpg",
                Description =
                    "Maybelline FIT ME! Matte + Poreless Foundation goes beyond  skin tone  matching to fit the unique texture issues of normal to oily skin for  the ultimate natural skin fit.  While some foundations can exaggerate pores and oily skin, only Maybelline's  pore-minimizing foundation contains their genius blurring micro-powders  that erase pores and absorb oil for a naturally matte and  poreless-looking finish.Dermatologist and allergy tested.  Does not clog pores. Oil-free.     "
            },
            new()
            {
                ProductId = 317, Brand = "maybelline", Name = "Maybelline Fit Me Foundation with SPF", Price = 10.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/eccb88d484b8c929fd349b0995a5dba2_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "It’s face makeup that fits you!Features: No oils, no waxes, no nonsenseNatural, Light to medium coverage that leaves skin the way it was meant to be. Fresh, breathing, flawless.Exclusive transluscent base and lightweight pigments allow skin’s natural highs and lows to show through.New shades formulated specifically for women of color contain  revolutionary 5-D pigment technology to balance your skin’s authentic  tones and highlights.SPF 18"
            },
            new()
            {
                ProductId = 309, Brand = "maybelline", Name = "Maybelline Expert Wear Eye Shadow Quad", Price = 8.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/c924006882e8e313d445a3a5394e4729_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Easy to use, lots to choose!Maybelline Expert Wear Eye Shadow  Quads have 4 coordinating shades with step by step application guide  makes shadow easier than ever. The eyeshadows glide on effortlessly with  superior smoothness and the velvet-tip applicator blends without  tugging or pulling. Safe for sensitive eyes and contact lens wearers,  ophthalmologist-tested.For best results sweep the brush 4 times:Apply base color. Sweep shade on lid. Contour crease and blend. Line around eye."
            },
            new()
            {
                ProductId = 307, Brand = "maybelline", Name = "Maybelline Eyestudio Color Tattoo Concentrated Crayon",
                Price = 10.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/3f9f894b56e0616e44c5ee01dea45217_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline Eyestudio Color Tattoo Concentrated Crayons give you high-intensity color that looks vibrant all-day long.Features:Smooth, soft creamy finishPlayful intense colorsAll day tattoo tenacity. Playful color intensity. In an easy glide on crayon."
            },
            new()
            {
                ProductId = 295, Brand = "maybelline", Name = "Maybelline The Nudes Eye Shadow Palette", Price = 17.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/201350fd3e173307ade44520dc87d8fb_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Maybelline The Nudes Eye Shadow Palette let's you create looks from day to night. Deep to light. So try it out and create your ideal eye look today!Features:             13 looks in one Expert Wear eyeshadow palette Extraordinary Colour, from soft highlights, to medium bronze, to rich black From Maybelline's ultra-blendable pigments Long Wear            "
            },
            new()
            {
                ProductId = 291, Brand = "maybelline",
                Name = "Maybelline Eye Studio Color Tattoo 24HR Cream Gel Shadow Leather", Price = 8.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/cf21d194ab14ee3c527d02682c358a7a_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "                          So rich. So creamy. Only Maybelline's cream gel eye shadow formula gets the look of couture leather so right!            Dare to wear Maybelline Color Tattoo leather 24HR long wear eye shadow.Features: Ink technology creates 24HR wear shadow for our most intense, long-lasting color saturationCream eye shadow formula glides on without creasing and keeps color vibrantOphthalmologist-tested.  Safe for sensitive eyes and contact lens wearers   Shade Range:                                          "
            },
            new()
            {
                ProductId = 286, Brand = "maybelline", Name = "Maybelline The Nudes Eyeshadow Palette in The Blushed Nudes",
                Price = 17.99,
                ImageLink =
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/49d98e112e77d2a9a0c8fad28df89a1e_ra,w158,h184_pa,w158,h184.png",
                Description =
                    "Create looks from day to night and deep to light with Maybelline's The Blushed Nudes Eyeshadow Palette.Features:13 looks in one eyeshadow paletteExtraordinary colour from ultra-blendable pigmentsLong wear with sensual finish that lasts up to 12 hours"
            }
        };
    }

    public IEnumerable<Product> GetProducts(string filter = null)
    {
        if (string.IsNullOrEmpty(filter)) return products;

        return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
    }

    public Product GetProduct(int id)
    {
        return products.FirstOrDefault(x => x.ProductId == id);
    }
}