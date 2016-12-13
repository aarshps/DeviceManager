using DeviceManager.Filters;
using DeviceManager.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DeviceManager.Controllers
{
    [AllowCors]
    [RoutePrefix("device")]
    public class DeviceController : ApiController
    {
        [HttpGet]
        [Route("get-all-devices")]
        public List<Device> GetAllDevices()
        {
            DEV_DMDBEntities context = new DEV_DMDBEntities();
            return context.Devices.ToList();
        }
    }
}