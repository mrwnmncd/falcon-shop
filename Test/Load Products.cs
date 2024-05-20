using App.Models;

namespace App.Testing;

public class ShopUtilities {
    public static void LoadProducts(Store store) {
        Console.WriteLine("TESTING [UTILITY] LOAD PRODUCTS");

        string[,] items = new string[,] {
            { "Male Polo - Extra Small", "UNIFORM-001", "460" },
            { "Male Polo - Small", "UNIFORM-002", "460" },
            { "Male Polo - Medium", "UNIFORM-003", "460" },
            { "Male Polo - Large", "UNIFORM-004","460" },
            { "Male Polo - Extra Large", "UNIFORM-005", "460" },
            { "Male Polo - Double Extra Large", "UNIFORM-006", "460" },
            { "Female Blouse - Extra Small", "UNIFORM-011", "460" },
            { "Female Blouse - Small", "UNIFORM-012", "460" },
            { "Female Blouse - Medium", "UNIFORM-013", "460" },
            { "Female Blouse - Large", "UNIFORM-014", "460" },
            { "Female Blouse - Extra Large", "UNIFORM-015", "460" },
            { "Female Blouse - Double Extra Large", "UNIFORM-016", "460" },
            { "Male Slacks - Extra Small", "UNIFORM-021", "460" },
            { "Male Slacks - Small", "UNIFORM-022", "460" },
            { "Male Slacks - Medium", "UNIFORM-023", "460" },
            { "Male Slacks - Large", "UNIFORM-024", "460" },
            { "Male Slacks - Extra Large", "UNIFORM-025", "460" },
            { "Male Slacks - Double Extra Large", "UNIFORM-026", "460" },
            { "Female Skirt - Extra Small", "UNIFORM-031", "460" },
            { "Female Skirt - Small", "UNIFORM-032", "460" },
            { "Female Skirt - Medium", "UNIFORM-033", "460" },
            { "Female Skirt - Large", "UNIFORM-034", "460" },
            { "Female Skirt - Extra Large", "UNIFORM-035", "460" },
            { "Female Skirt - Double Extra Large", "UNIFORM-036", "460" },
            { "Unisex PE Shirt - Extra Small", "UNIFORM-041", "460" },
            { "Unisex PE Shirt - Small", "UNIFORM-042", "460" },
            { "Unisex PE Shirt - Medium", "UNIFORM-043", "460" },
            { "Unisex PE Shirt - Large", "UNIFORM-044", "460" },
            { "Unisex PE Shirt - Extra Large", "UNIFORM-045", "460" },
            { "Unisex PE Shirt - Double Extra Large", "UNIFORM-046", "460" },
            { "Unisex Jogging Pants - Extra Small", "UNIFORM-051", "460" },
            { "Unisex Jogging Pants - Small", "UNIFORM-052", "460" },
            { "Unisex Jogging Pants - Medium", "UNIFORM-053", "460" },
            { "Unisex Jogging Pants - Large", "UNIFORM-054", "460" },
            { "Unisex Jogging Pants - Extra Large", "UNIFORM-054", "460" },
            { "Unisex Jogging Pants - Double Extra Large", "UNIFORM-055", "460" },
            { "Unisex NSTP Shirt - Extra Small", "UNIFORM-061", "460" },
            { "Unisex NSTP Shirt - Small", "UNIFORM-062", "460" },
            { "Unisex NSTP Shirt - Medium", "UNIFORM-063", "460" },
            { "Unisex NSTP Shirt - Large", "UNIFORM-064", "460" },
            { "Unisex NSTP Shirt - Extra Large", "UNIFORM-065", "460" },
            { "Unisex NSTP Shirt - Double Extra Large", "UNIFORM-066", "460" },
            { "Lanyard - College of Architecture", "ACCESSORIES-011", "460" },
            { "Lanyard - College of Business Administration", "ACCESSORIES-010", "460" },
            { "Lanyard - College of Engineering", "ACCESSORIES-009", "460" },
            { "Lanyard - College of Law", "ACCESSORIES-008", "460" },
            { "Lanyard - College of Education and Liberal Arts", "ACCESSORIES-002", "460" },
            { "Lanyard - College of Nursing", "ACCESSORIES-003", "460" },
            { "Lanyard - College of Pharmacy", "ACCESSORIES-004", "460" },
            { "Lanyard - College of Science", "ACCESSORIES-001", "460" },
            { "Lanyard - Graduate School", "ACCESSORIES-005", "460" },
            { "Lanyard - St. Vincent School of Theology", "ACCESSORIES-006", "460" },
            { "Lanyard - Basic Education Department", "ACCESSORIES-007", "460" }
        };
        
        for (int i = 0; i < items.GetLength(0); i++) {
            store.AddProduct(new InventoryItem() {
                Name = items[i, 0],
                Id = items[i, 1],
                Price = double.Parse(items[i, 2]),
                Quantity = 1000
            });
        }

    }
}