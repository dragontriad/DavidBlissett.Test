﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DavidBlissett.Test.Host.Services;
using DavidBlissett.Test.Shared;
using DavidBlissett.Test.WebAPI.Models;

namespace DavidBlissett.Test.App.Services
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly HttpClient _httpClient;

        // Constructor to inject HttpClient
        public CustomerDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Adds a new customer by calling the API's POST method
        public async Task<Customer> AddCustomer(Customer customer)
        {
            var customerJson = new StringContent(JsonSerializer.Serialize(customer), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Customer", customerJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Customer>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        // Deletes a customer by ID by calling the API's DELETE method
        public async Task DeleteCustomer(int customerId)
        {
            await _httpClient.DeleteAsync($"api/Customer/{customerId}");
        }

        // Retrieves all customers by calling the API's GET method
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Customer>>(
                await _httpClient.GetStreamAsync("api/Customer"),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        // Retrieves a specific customer by ID
        public async Task<Customer> GetCustomerById(int customerId)
        {
            return await JsonSerializer.DeserializeAsync<Customer>(
                await _httpClient.GetStreamAsync($"api/Customer/{customerId}"),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        // Updates an existing customer by calling the API's PUT method
        public async Task UpdateCustomer(Customer customer)
        {
            var customerJson = new StringContent(JsonSerializer.Serialize(customer), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"api/Customer/{customer.CustomerID}", customerJson);
        }
    }
}
