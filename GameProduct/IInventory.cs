using System;
namespace GameProduct
{
	public interface IInventory
	{
		/// <summary>
        /// A list of maximum 10_000 GameProducts
        /// </summary>
		public List<GameProduct> InventoryList { get; set; }

		/// <summary>
        /// Total number of products on Stock
        /// </summary>
		public int StockCount { get; }

		/// <summary>
        /// Total Value of products on Stock
        /// </summary>
		public decimal StockValue { get; }

		/// <summary>
        /// Removes a prod using IEquatable from the InventoryList
        /// </summary>
        /// <param name="prod">Product to be removed</param>
        /// <returns>True if successful, otherwise false</returns>
		public bool Remove(GameProduct prod);
	}
}

