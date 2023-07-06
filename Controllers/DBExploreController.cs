using System.Linq;
using System.Threading.Tasks;
using KSIMonitor.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KSIMonitor.Controllers {
    [Authorize(Roles = Program.RoleNameDBAdmin)]
    public class DBExploreController : Controller {
        private readonly ILogger<DBExploreController> logger;
        private readonly SETContext setContext;
        public DBExploreController(ILogger<DBExploreController> logger, SETContext setContext) {
            this.logger = logger;
            this.setContext = setContext;
        }

        // GET: DBExploreController
        public IActionResult Index() {
            var tables = setContext.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly);
            return View(tables.Select(t => t.Name));
        }
    }
}
