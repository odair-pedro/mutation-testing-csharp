using System;

namespace Mutation.Store.Example
{
    public class Dimensions
    {
        public decimal Height { get; }
        public decimal Width { get; }
        public decimal Depth { get; }

        public Dimensions(decimal height, decimal width, decimal depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }

        public override string ToString()
        {
            if (Height == 0 && Width == 0 && Depth == 0)
                return "No dimensions";
            
            return $"HxWxD: {Height}x{Width}x{Depth}";;
        }

        public void Validate()
        {
            if (Height <= 0)
                throw new Exception("Height can not be equal or less than zero");

            if (Width <= 0)
                throw new Exception("Width can not be equal or less than zero");
            
            if (Depth <= 0)
                throw new Exception("Depth can not be equal or less than zero");
        }
    }
}