using App.Models;

namespace App.Testing;

public class ShopUtilities {
    public static void LoadProducts(Store store) {
        Console.WriteLine("TESTING [UTILITY] LOAD PRODUCTS");

        string[,] items = new string[,] {
            { "Male Polo - Extra Small", "UNIFORM-001", "460" },
            { "Male Polo - Small", "UNIFORM-002", "460" },
            { "Male Polo - Medium", "UNIFORM-003", "460" },
            { "Male Polo - Large", "UNIFORM-004","490" },
            { "Male Polo - Extra Large", "UNIFORM-005", "490" },
            { "Male Polo - Double Extra Large", "UNIFORM-006", "510" },
            { "Female Blouse - Extra Small", "UNIFORM-011", "430" },
            { "Female Blouse - Small", "UNIFORM-012", "430" },
            { "Female Blouse - Medium", "UNIFORM-013", "430" },
            { "Female Blouse - Large", "UNIFORM-014", "460" },
            { "Female Blouse - Extra Large", "UNIFORM-015", "460" },
            { "Female Blouse - Double Extra Large", "UNIFORM-016", "480" },
            { "Male Slacks - Extra Small", "UNIFORM-021", "450" },
            { "Male Slacks - Small", "UNIFORM-022", "450" },
            { "Male Slacks - Medium", "UNIFORM-023", "450" },
            { "Male Slacks - Large", "UNIFORM-024", "480" },
            { "Male Slacks - Extra Large", "UNIFORM-025", "480" },
            { "Male Slacks - Double Extra Large", "UNIFORM-026", "510" },
            { "Female Skirt - Extra Small", "UNIFORM-031", "425" },
            { "Female Skirt - Small", "UNIFORM-032", "425" },
            { "Female Skirt - Medium", "UNIFORM-033", "425" },
            { "Female Skirt - Large", "UNIFORM-034", "450" },
            { "Female Skirt - Extra Large", "UNIFORM-035", "450" },
            { "Female Skirt - Double Extra Large", "UNIFORM-036", "460" },
            { "Unisex PE Shirt - Extra Small", "UNIFORM-041", "200" },
            { "Unisex PE Shirt - Small", "UNIFORM-042", "200" },
            { "Unisex PE Shirt - Medium", "UNIFORM-043", "200" },
            { "Unisex PE Shirt - Large", "UNIFORM-044", "200" },
            { "Unisex PE Shirt - Extra Large", "UNIFORM-045", "200" },
            { "Unisex PE Shirt - Double Extra Large", "UNIFORM-046", "200" },
            { "Unisex Jogging Pants - Extra Small", "UNIFORM-051", "320" },
            { "Unisex Jogging Pants - Small", "UNIFORM-052", "320" },
            { "Unisex Jogging Pants - Medium", "UNIFORM-053", "320" },
            { "Unisex Jogging Pants - Large", "UNIFORM-054", "320" },
            { "Unisex Jogging Pants - Extra Large", "UNIFORM-054", "320" },
            { "Unisex Jogging Pants - Double Extra Large", "UNIFORM-055", "320" },
            { "Unisex NSTP Shirt - Extra Small", "UNIFORM-061", "250" },
            { "Unisex NSTP Shirt - Small", "UNIFORM-062", "250" },
            { "Unisex NSTP Shirt - Medium", "UNIFORM-063", "250" },
            { "Unisex NSTP Shirt - Large", "UNIFORM-064", "250" },
            { "Unisex NSTP Shirt - Extra Large", "UNIFORM-065", "250" },
            { "Unisex NSTP Shirt - Double Extra Large", "UNIFORM-066", "250" },
            { "Lanyard for College of Architecture", "ACCESSORIES-011", "95" },
            { "Lanyard for College of Business Administration", "ACCESSORIES-010", "95" },
            { "Lanyard for College of Engineering", "ACCESSORIES-009", "95" },
            { "Lanyard for College of Law", "ACCESSORIES-008", "460" },
            { "Lanyard for College of Education and Liberal Arts", "ACCESSORIES-002", "95" },
            { "Lanyard for College of Nursing", "ACCESSORIES-003", "95" },
            { "Lanyard for College of Pharmacy", "ACCESSORIES-004", "95" },
            { "Lanyard for College of Science", "ACCESSORIES-001", "95" },
            { "Lanyard for Graduate School", "ACCESSORIES-005", "95" },
            { "Lanyard for St. Vincent School of Theology", "ACCESSORIES-006", "95" },
            { "Lanyard for Basic Education Department", "ACCESSORIES-007", "95" }
        };

        foreach (var item in items) {
            Console.WriteLine(item);
            Console.WriteLine(item[0]);
            Console.WriteLine(item[1]);
            Console.WriteLine(item[2]);
            // store.AddProduct(new InventoryItem() {
            //     Name = item[0],
            //     Id = item[1],
            //     Price = decimal.Parse(item[2])
            // });
        }

    }
}