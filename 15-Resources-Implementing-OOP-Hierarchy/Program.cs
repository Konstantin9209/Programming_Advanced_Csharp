using ExerciseOopHierarchy;
using System;

Console.WriteLine("Uncomment the code!");
// Initialize the restaurant
Restaurant restaurant = new();

// Create menu items
MenuItem main = new MainCourseMenuItem("Pasta", "Delicious pasta dish", 12.99m);
MenuItem appetizer = new AppetizerMenuItem("Salad", "Fresh garden salad", 7.99m);
MenuItem dessert = new DessertMenuItem("Cheesecake", "Creamy cheesecake", 5.99m);

// Add menu items to the restaurant
restaurant.AddMenuItem(main);
restaurant.AddMenuItem(appetizer);
restaurant.AddMenuItem(dessert);

// Create customers
Customer customer1 = new("John Doe", "john.doe@example.com");
Customer customer2 = new("Jane Smith", "jane.smith@example.com");

// Add customers to the restaurant
restaurant.AddCustomer(customer1);
restaurant.AddCustomer(customer2);

// Create and place an order for customer1
Order order = new();
order.AddItem(restaurant.GetMenuItem(0)); // Add main course
order.AddItem(restaurant.GetMenuItem(2)); // Add dessert
restaurant.PlaceOrder(customer1, order);

// Display the restaurant menu and the order history for customer1
restaurant.DisplayMenu();
restaurant.DisplayOrderHistory(customer1);
