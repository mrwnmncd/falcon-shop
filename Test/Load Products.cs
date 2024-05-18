using App.Models;

namespace App.Testing;

public class ShopUtilities {
    public static void LoadProducts(Store store) {
        Console.WriteLine("TESTING [UTILITY] LOAD PRODUCTS");
        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-001",
            Name = "Polo",
            Description = "Adamson University Polo Shirt for Men",
            Price = 460,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "White" },
                { "Type", "Polo" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-002",
            Name = "Polo",
            Description = "Adamson University Polo Shirt for Men",
            Price = 460,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "White" },
                { "Type", "Polo" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-003",
            Name = "Polo",
            Description = "Adamson University Polo Shirt for Men",
            Price = 460,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "White" },
                { "Type", "Polo" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-004",
            Name = "Polo",
            Description = "Adamson University Polo Shirt for Men",
            Price = 490,
            Specifications = new () {
                { "Size", "L" },
                { "Color", "White" },
                { "Type", "Polo" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-005",
            Name = "Polo",
            Description = "Adamson University Polo Shirt for Men",
            Price = 490,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "White" },
                { "Type", "Polo" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-006",
            Name = "Pants",
            Description = "Adamson University Pants for Men",
            Price = 450,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-007",
            Name = "Pants",
            Description = "Adamson University Pants for Men",
            Price = 450,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-008",
            Name = "Pants",
            Description = "Adamson University Pants for Men",
            Price = 450,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-009",
            Name = "Pants",
            Description = "Adamson University Pants for Men",
            Price = 480,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-010",
            Name = "Pants",
            Description = "Adamson University Pants for Men",
            Price = 480,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-011",
            Name = "Blouse",
            Description = "Adamson University Blouse for Women",
            Price = 430,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "White" },
                { "Type", "Blouse" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-012",
            Name = "Blouse",
            Description = "Adamson University Blouse for Women",
            Price = 430,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "White" },
                { "Type", "Blouse" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-013",
            Name = "Blouse",
            Description = "Adamson University Blouse for Women",
            Price = 430,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "White" },
                { "Type", "Blouse" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-014",
            Name = "Blouse",
            Description = "Adamson University Blouse for Women",
            Price = 460,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "White" },
                { "Type", "Blouse" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-015",
            Name = "Blouse",
            Description = "Adamson University Blouse for Women",
            Price = 460,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "White" },
                { "Type", "Blouse" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-016",
            Name = "Pants",
            Description = "Adamson University Pants for Women",
            Price = 425,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-017",
            Name = "Pants",
            Description = "Adamson University Pants for Women",
            Price = 425,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-018",
            Name = "Pants",
            Description = "Adamson University Pants for Women",
            Price = 425,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-019",
            Name = "Pants",
            Description = "Adamson University Pants for Women",
            Price = 450,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-020",
            Name = "Pants",
            Description = "Adamson University Pants for Women",
            Price = 450,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-021",
            Name = "Skirt",
            Description = "Adamson University Skirt for Women",
            Price = 425,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "Navy Blue" },
                { "Type", "Skirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-022",
            Name = "Skirt",
            Description = "Adamson University Skirt for Women",
            Price = 425,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "Navy Blue" },
                { "Type", "Skirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-023",
            Name = "Skirt",
            Description = "Adamson University Skirt for Women",
            Price = 425,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "Navy Blue" },
                { "Type", "Skirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-024",
            Name = "Skirt",
            Description = "Adamson University Skirt for Women",
            Price = 450,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "Navy Blue" },
                { "Type", "Skirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-025",
            Name = "Skirt",
            Description = "Adamson University Skirt for Women",
            Price = 450,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "Navy Blue" },
                { "Type", "Skirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-026",
            Name = "PE Shirt",
            Description = "Adamson University PE Shirt",
            Price = 200,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "White" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-027",
            Name = "PE Shirt",
            Description = "Adamson University PE Shirt",
            Price = 200,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "White" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-028",
            Name = "PE Shirt",
            Description = "Adamson University PE Shirt",
            Price = 200,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "White" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-029",
            Name = "PE Shirt",
            Description = "Adamson University PE Shirt",
            Price = 200,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "White" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-030",
            Name = "PE Shirt",
            Description = "Adamson University PE Shirt",
            Price = 200,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "White" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-031",
            Name = "PE Pants",
            Description = "Adamson University PE Pants",
            Price = 320,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-032",
            Name = "PE Pants",
            Description = "Adamson University PE Pants",
            Price = 320,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-033",
            Name = "PE Pants",
            Description = "Adamson University PE Pants",
            Price = 320,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-034",
            Name = "PE Pants",
            Description = "Adamson University PE Pants",
            Price = 320,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-035",
            Name = "PE Pants",
            Description = "Adamson University PE Pants",
            Price = 320,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "Navy Blue" },
                { "Type", "Pants" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-036",
            Name = "NSTP Shirt",
            Description = "Adamson University NSTP Shirt",
            Price = 250,
            Specifications = new() {
                { "Size", "XS" },
                { "Color", "Blue" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-037",
            Name = "NSTP Shirt",
            Description = "Adamson University NSTP Shirt",
            Price = 250,
            Specifications = new() {
                { "Size", "S" },
                { "Color", "Blue" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-038",
            Name = "NSTP Shirt",
            Description = "Adamson University NSTP Shirt",
            Price = 250,
            Specifications = new() {
                { "Size", "M" },
                { "Color", "Blue" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-039",
            Name = "NSTP Shirt",
            Description = "Adamson University NSTP Shirt",
            Price = 250,
            Specifications = new() {
                { "Size", "L" },
                { "Color", "Blue" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "UNIFORM-040",
            Name = "NSTP Shirt",
            Description = "Adamson University NSTP Shirt",
            Price = 250,
            Specifications = new() {
                { "Size", "XL" },
                { "Color", "Blue" },
                { "Type", "T-Shirt" },
                { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-001",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Orange" },
                { "College", "Engineering" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-002",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Pink" },
                { "College", "Nursing" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-003",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Light Purple" },
                { "College", "Law" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-004",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Yellow" },
                { "College", "Business Management" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-005",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Peach" },
                { "College", "Science" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-006",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Red" },
                { "College", "Architecture" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-007",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Blue" },
                { "College", "Communication" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-008",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Violet" },
                { "College", "Pharmacy" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-009",
            Name = "Lanyard",
            Description = "Adamson University Lanyard",
            Price = 95,
            Specifications = new() {
                { "Color", "Green" },
                { "College", "Graduate School" }, {
                    "Variants",
                    new[] {
                        "Engineering", "Nursing", "Law", "Business Management", "Science", "Architecture", "Communication",
                        "Pharmacy", "Graduate School"
                    }
                }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-010",
            Name = "Notebook",
            Description = "Notebook with Adamson Logo",
            Price = 150,
            Specifications = new() {
                { "Color", "Black" },
                { "Type", "Notebook" }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-011",
            Name = "Notebook",
            Description = "Adamson University Notebook with Post It",
            Price = 75,
            Specifications = new() {
                { "Color", "Blue" },
                { "Type", "Notebook" }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-012",
            Name = "Notebook",
            Description = "Adamson University Notebook with Pen",
            Price = 100,
            Specifications = new() {
                { "Color", "Blue" },
                { "Type", "Notebook" }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-013",
            Name = "Notebook",
            Description = "Adamson University Notebook with Post It",
            Price = 75,
            Specifications = new() {
                { "Color", "Blue" },
                { "Type", "Notebook" }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-014",
            Name = "Fillers",
            Description = "Adamson University Fillers",
            Price = 10,
            Specifications = new() {
                { "Color", "Gray" },
                { "Type", "Filler" },
                { "Variants", new[] { "Gray", "Yellow", "Green" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-015",
            Name = "Fillers",
            Description = "Adamson University Fillers",
            Price = 10,
            Specifications = new() {
                { "Color", "Yellow" },
                { "Type", "Filler" },
                { "Variants", new[] { "Gray", "Yellow", "Green" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-016",
            Name = "Fillers",
            Description = "Adamson University Fillers",
            Price = 10,
            Specifications = new() {
                { "Color", "Green" },
                { "Type", "Filler" },
                { "Variants", new[] { "Gray", "Yellow", "Green" } }
            },
            Quantity = 1000
        });

        store.AddProduct(new InventoryItem() {
            Id = "MERCH-017",
            Name = "Ballpen",
            Description = "Adamson University Ballpen with Case",
            Price = 50,
            Specifications = new() {
                { "Color", "Blue" },
                { "Type", "Ballpen" },
            },
            Quantity = 1000
        });
    }
}