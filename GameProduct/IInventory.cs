using System;
namespace GameProduct
{
	public interface IInventory
	{
		public List<GameProduct> Inventory { get; set; }

		public int StockCount { get; }
		public decimal StockValue { get; }
	}
}

