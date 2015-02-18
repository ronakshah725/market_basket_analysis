using System;
namespace AprioriAlgorithm
{
    public class Item : IComparable<Item>
    {
        #region Public Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Support { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        #endregion

        #region IComparable

        public int CompareTo(Item other)
        {
            return Name.CompareTo(other.Name);
        } 

        #endregion
    }
}