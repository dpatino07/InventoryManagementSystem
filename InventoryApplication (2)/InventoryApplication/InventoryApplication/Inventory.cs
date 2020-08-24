using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public class Inventory
    {

        // Create Binding Lists for Product and Part
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();



        // Methods for parts (add, delete, lookup and update)
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(Part removedPart)
        {// Require user to confirm if they want to delete
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                // Prevent user from deleting products with associated parts
                foreach (Part part in AllParts)
                {
                    if (part.PartID == removedPart.PartID)
                    {
                        AllParts.Remove(part);
                        return true;
                    }
                }
            }
            return false;
        }

        public static Part LookupPart(int partID)
        {
            Part returnPart = null;

            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    returnPart = part;
                }
            }
            return returnPart;
        }

        public static void UpdatePart(int partID, Part updatedPart)
        {
            foreach (Part part in AllParts)
            {
                if(part.PartID == partID)
                {
                    part.Name = updatedPart.Name;
                    part.InStock = updatedPart.InStock;
                    part.Price = updatedPart.Price;
                    part.Max = updatedPart.Max;
                    part.Min = updatedPart.Min;
                    return;
                }
            }
        }

        // Methods for products (add, delete, lookup and update)
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            foreach (var product in Products)
            {
                if (productID == product.ProductID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }
        public static Product LookupProduct(int productID)
        {
            Product productToView = null;

            foreach (var product in Products)
            {
                if(product.ProductID == productID)
                {
                    productToView = product;
                }
            }
            return productToView;
        }
        
        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    product.AssociatedParts = updatedProduct.AssociatedParts;
                    product.Name = updatedProduct.Name;
                    product.Price = updatedProduct.Price;
                    product.InStock = updatedProduct.InStock;
                    product.Max = updatedProduct.Max;
                    product.Min = updatedProduct.Min;
                    return;
                }
            }
        }
    }
}
