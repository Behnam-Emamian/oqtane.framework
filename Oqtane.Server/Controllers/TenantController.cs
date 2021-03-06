﻿using Microsoft.AspNetCore.Mvc;
using Oqtane.Repository;
using Oqtane.Models;
using System.Collections.Generic;

namespace Oqtane.Controllers
{
    [Route("{site}/api/[controller]")]
    public class TenantController : Controller
    {
        private readonly ITenantRepository tenants;

        public TenantController(ITenantRepository Tenants)
        {
            tenants = Tenants;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Tenant> Get()
        {
            return tenants.GetTenants();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Tenant Get(int id)
        {
            return tenants.GetTenant(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Tenant site)
        {
            if (ModelState.IsValid)
                tenants.AddTenant(site);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tenant site)
        {
            if (ModelState.IsValid)
                tenants.UpdateTenant(site);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tenants.DeleteTenant(id);
        }
    }
}
