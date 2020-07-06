using System;

namespace Mutation.Store.Example
{
    public class Category : Entity
    {
        public string Name { get; }
        public int Code { get; }

        public Category(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }
        
        public void Validate()
        {
            if (Id == Guid.Empty)
                throw new Exception("Id shall not be empty");
            
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Name shall not be null or empty");

            if (Code == default)
                throw new Exception("Code shall not be empty");
        }
    }
}