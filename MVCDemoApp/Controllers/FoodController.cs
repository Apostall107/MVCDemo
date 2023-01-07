using DataLibrary.Data;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemoApp.Controllers
{
	public class FoodController : Controller
	{
		private readonly IFoodData _foodData;
		private readonly IOrderData _orderData;

		public FoodController(IFoodData foodData, IOrderData orderData)
		{
			_foodData = foodData;
			_orderData = orderData;
		}
		public async Task<IActionResult> Index()
		{
			var foodList = await _foodData.GetAll();
			return View(_foodData);
		}
	}
}
