using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Infraestructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages.Operation
{
    public class IndexModel : PageModel
    {
        public  OperationService _operationService;
        public IOperationTransient _transientOperation;
        public IOperationScoped _scopedOperation;
        public IOperationSingleton _singletonOperation;
        public IOperationSingletonInstance _singletonInstanceOperation;
        public int Count;

        public IndexModel(IOperationTransient transientOperation,
                                   IOperationScoped scopedOperation,
                                   IOperationSingleton singletonOperation,
                                   IOperationSingletonInstance singletonInstanceOperation,
                                   OperationService operationService)
        {
         //   Count = 0;
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }
        public IActionResult OnGet()
        {
            Count++;
            return Page();

        }
    }
}