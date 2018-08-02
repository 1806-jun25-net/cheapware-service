using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cheapware.Data.Models;
using Cheapware.Library.Models;
namespace Cheapware.Library.RepoClasses
{
    public interface IComputerRepo
    {
        //Misc Repo Methods
        Task Save();

        //Computer Case Repo Methods
        List<ComputerCase> GetComputerCases();
        ComputerCase GetComputerCaseByName(string name);

        //CPU Repo Methods
        List<CPU> GetCpus();
        CPU GetCpuByName(string name);
                
        //Graphics Card Repo Methods
        List<GraphicsCard> GetGraphicsCards();
        GraphicsCard GetGraphicsCardByName(string name);
        
        //Mother Board Repo Methods
        List<MotherBoard> GetMotherBoards();
        MotherBoard GetMotherBoardByName(string name);

        //Power Supply Repo Methods
        List<PowerSupply> GetPowerSupplys();
        PowerSupply GetPowerSupplyByName(string name);

        //Ram Repo Methods
        List<RAM> GetRams();
        RAM GetRamByName(string name);

        //Customer Repo Methods
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int id);
        Customer GetCustomerByName(string name);
        Customer GetCustomerByUserName(string name);

        //Hard Drive Repo Methods
        Task<List<HardDrive>> GetHardDrives();
        Task<HardDrive> GetHardDriveByName(string name);

        //Inventory Repo Methods
        Task<List<Inventory>> GetInventoryByCategory(string cat);
        Task<List<Inventory>> GetInventory();
        Task<Inventory> GetProductByName(string name);

        //Order Repo Methods
        Task<List<PartsOrder>> GetOrdersByCustomerId(int id);
        void AddOrder(PartsOrder order);
        Task<PartsOrder> GetOrderById(int id);

        //Cart Repo Methods
        Task<List<Cart>> GetCartByCustomerId(int id);
        void AddCart(Cart cart);
        Task<Cart> GetCartById(int id);



    }
}
