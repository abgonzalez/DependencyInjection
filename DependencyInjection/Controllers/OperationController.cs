using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Infraestructure;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Contollers
{
    public class OperationController : Controller
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;
        public OperationController(IOperationTransient transientOperation,
                                   IOperationScoped scopedOperation,
                                   IOperationSingleton singletonOperation,
                                   IOperationSingletonInstance singletonInstanceOperation,
                                   OperationService operationService)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }
        public IActionResult Index()
        {
            // ViewBag contains controller-requested services
            ViewBag.Transient = _transientOperation;
            ViewBag.Scoped = _scopedOperation;
            ViewBag.Singleton = _singletonOperation;
            ViewBag.SingletonInstance = _singletonInstanceOperation;

            // Operation service has its own requested services
            ViewBag.Service = _operationService;
            return View();
        }
    }
}
