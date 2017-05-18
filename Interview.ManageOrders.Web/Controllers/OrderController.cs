using AutoMapper;
using Interview.ManageOrders.BusinessEntities.Models;
using Interview.ManageOrders.BusinessServices.Interfaces;
using Interview.ManageOrders.DTO.Mappers;
using Interview.ManageOrders.Web.ViewModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview.ManageOrders.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService orderServices;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public OrderController(IOrderService _orderServices)
        {
            this.orderServices = _orderServices;
        }

        // GET: Order


        public ActionResult Index()
        {
            try
            {
                List<ServiceOrder> serviceOrders = GetOrders();

                var ServiceOrderEntites = Mapper.Map<List<ServiceOrder>, List<ServiceOrderEntity>>(serviceOrders);


                /*Intentionally limited to 2 */
                IEnumerable<OrderViewModel> viewModelList = ServiceOrderEntites
                     .GroupBy(s => s.OrdersID)
                     .Take(2)
                     .Select(g => new OrderViewModel
                     {
                         AccountNumber = g.FirstOrDefault().Order.AccountNumber,
                         CustomerName = g.FirstOrDefault().Order.CustomerName,
                         OrdersID = g.FirstOrDefault().Order.OrdersID,
                         ServiceTypes = g.Count()
                     });
               
                return View(viewModelList);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "error occured");
                return View("Error", new HandleErrorInfo(ex, "Order", "Index"));
            }

        }

        [HttpGet]
        public ActionResult ViewAll()
        {
            try
            {
                List<ServiceOrder> serviceOrders = GetOrders();
                
                var ServiceOrderEntites = Mapper.Map<List<ServiceOrder>, List<ServiceOrderEntity>>(serviceOrders);

                IEnumerable<OrderViewModel> viewModelList = ServiceOrderEntites
                    .GroupBy(s => s.OrdersID)
                    .Select(g => new OrderViewModel
                    {
                        AccountNumber = g.FirstOrDefault().Order.AccountNumber,
                        CustomerName = g.FirstOrDefault().Order.CustomerName,
                        OrdersID = g.FirstOrDefault().Order.OrdersID,
                        ServiceTypes = g.Count()
                    });

                return PartialView(viewModelList);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "error occured");
                return View("Error", new HandleErrorInfo(ex, "Order", "Index"));
            }

        }


        public ActionResult Create()
        {


            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrder()
        {

            /* 
            * 
            * Need to add logic for creating orders
            * */

            return View();
        }

        private List<ServiceOrder> GetOrders()
        {
            return this.orderServices.GetOrders();
        }

    }
}
