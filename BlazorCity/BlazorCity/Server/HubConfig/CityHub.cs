using BlazorCity.Server.Data;
using BlazorCity.Shared.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCity.Server.HubConfig
{
    public class CityHub : Hub
    {
        private readonly CityDbContext _cityDbContext;

        public CityHub (CityDbContext cityDbContext)
        {
            this._cityDbContext = cityDbContext;
        }

        public async Task SendAllCities()
        {
            IEnumerable<City> cities;

            cities = await _cityDbContext.Cities.ToArrayAsync();

            await Clients.Caller.SendAsync("ReceiveAllCities", cities);
        }

        public async Task SendOneCity(int id)
        {
            var city = await _cityDbContext.Cities.FindAsync(id);

            await Clients.Caller.SendAsync("ReceiveOneCity", city);
        } 

        public async Task SendDeleteCity(int id)
        {
            var city = await _cityDbContext.Cities.FindAsync(id);

            _cityDbContext.Remove(city);
            await _cityDbContext.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveDeleteCity", city.CityId);
        }

        
        public async Task SendEditCity(City city)
        {
            _cityDbContext.Entry(city).State = EntityState.Modified;
            await _cityDbContext.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveEditCity", city);
        }

        public async Task SendAddCity(City city)
        {
            _cityDbContext.Cities.Add(city);
            await _cityDbContext.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveAddCity", city);
        }
        
    }
}
