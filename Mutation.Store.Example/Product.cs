using System;

namespace Mutation.Store.Example
{
    public class Product : Entity
    {
        public string Name { get; private set;  }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }
        public Dimensions Dimensions { get; }

        public Product(string name, string description, bool active, decimal price, Guid categoryId, Dimensions dimensions)
        {
            Name = name.Trim();
            Description = description.Trim();
            Active = active;
            Price = price;
            CategoryId = categoryId;
            Dimensions = dimensions;

            Validate();
        }

        public void Activate() => Active = true;
        
        public void Deactivate() => Active = false;
        
        public void ChangeCategory(Category category)
        {
            if (category == default)
                throw new Exception("Category shall not be null");
            
            Category = category;
            CategoryId = category.Id;
        }
        
        public void ChangeName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name shall not be empty");
            
            Name = name;
        }

        public void ChangeDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
                throw new Exception("Description shall not be empty");
            
            Description = description;
        }

        public void ChangePrice(decimal price)
        {
            if (price < 0) 
                throw new Exception("Price can not be less then zero");

            Price = price;
        }

        public void DebitStock(uint quatity)
        {
            if (!CheckStock(quatity))
                throw new Exception("Insuficient Stock");

            Quantity -= (int)quatity;
        }

        public void CreditStock(uint quantity)
        {
            Quantity += (int)quantity;
        }

        public bool CheckStock(uint quantity)
        {
            return Quantity >= quantity;
        }

        public void Validate()
        {
            if (Id == Guid.Empty)
                throw new Exception("Id shall not be empty");
            
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Name shall not be empty");
            
            if (string.IsNullOrEmpty(Description))
                throw new Exception("Description shall not be empty");
            
            if (Price < 0) 
                throw new Exception("Price can not be less then zero");
        }
    }
}