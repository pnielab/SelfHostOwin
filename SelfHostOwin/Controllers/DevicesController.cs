using System.Collections.Generic;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using SelfHostOwin.Dtos;

namespace SelfHostOwin.Controllers
{
    public class DevicesController : ApiController
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<DeviceDto> GetAllDevices()
        {
            return new DeviceDto[] { };
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public DeviceDto GetDevice([FromRoute] int id)
        {
            return new DeviceDto();
        }

        [Microsoft.AspNetCore.Mvc.HttpDelete]
        public string deleteDeviceById([FromRoute] int id)
        {
            return "Ok";
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public DeviceDto createDevice([System.Web.Http.FromBody] DeviceDto device)
        {
            return device;
        }

        [Microsoft.AspNetCore.Mvc.HttpPut]
        public DeviceDto updateDevice([System.Web.Http.FromBody] DeviceDto device)
        {
            return device;
        }
    }
}