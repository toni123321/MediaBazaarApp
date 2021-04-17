using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public class StockManagement
    {
        private List<Stock> stocks;
        private Dictionary<string, bool> stockStorage;


        public StockManagement()
        {
            this.stocks = new List<Stock>();
            this.stockStorage = new Dictionary<string, bool>();
        }

        public void AddStock(int id, string model, string brand, double price, int quantity, double height, double width, double depth, double weight, string shortDescription, string location)
        {
            if (SearchForStock(model, brand) != null)
            {
                SearchForStock(model, brand).Quantity += quantity;
            }
            else
            {
                Stock stock = new Stock(id, model, brand, price, quantity, height, width, depth, weight, shortDescription);
                stock.Location = location;
                stockStorage[location] = false;
                stocks.Add(stock);
            }
        }

        public Stock SearchForStock(string model, string brand)
        {
            foreach (Stock stock in stocks)
            {
                if (stock.Model == model && stock.Brand == brand)
                {
                    return stock;
                }
            }
            return null;
        }

        public void RemoveStock(Stock stock)
        {
            string stockLocation = stock.Location;
            stockStorage[stockLocation] = true;
            stocks.Remove(stock);
        }

        public Stock GetStock(int id)
        {
            foreach (Stock stock in stocks)
            {
                if (id == stock.Id)
                {
                    return stock;
                }
            }
            return null;
        }
        public List<Stock> GetAllStocks()
        {
            return this.stocks;
        }

        public void startStorage()
        {
            stockStorage.Add("A1", true);
            stockStorage.Add("A2", true);
            stockStorage.Add("A3", true);
            stockStorage.Add("A4", true);
            stockStorage.Add("A5", true);
            stockStorage.Add("A6", true);
            stockStorage.Add("A7", true);
            stockStorage.Add("A8", true);
            stockStorage.Add("A9", true);
            stockStorage.Add("A10", true);
            stockStorage.Add("B1", true);
            stockStorage.Add("B2", true);
            stockStorage.Add("B3", true);
            stockStorage.Add("B4", true);
            stockStorage.Add("B5", true);
            stockStorage.Add("B6", true);
            stockStorage.Add("B7", true);
            stockStorage.Add("B8", true);
            stockStorage.Add("B9", true);
            stockStorage.Add("B10", true);
            stockStorage.Add("C1", true);
            stockStorage.Add("C2", true);
            stockStorage.Add("C3", true);
            stockStorage.Add("C4", true);
            stockStorage.Add("C5", true);
            stockStorage.Add("C6", true);
            stockStorage.Add("C7", true);
            stockStorage.Add("C8", true);
            stockStorage.Add("C9", true);
            stockStorage.Add("C10", true);
            stockStorage.Add("D1", true);
            stockStorage.Add("D2", true);
            stockStorage.Add("D3", true);
            stockStorage.Add("D4", true);
            stockStorage.Add("D5", true);
            stockStorage.Add("D6", true);
            stockStorage.Add("D7", true);
            stockStorage.Add("D8", true);
            stockStorage.Add("D9", true);
            stockStorage.Add("D10", true);
            stockStorage.Add("E1", true);
            stockStorage.Add("E2", true);
            stockStorage.Add("E3", true);
            stockStorage.Add("E4", true);
            stockStorage.Add("E5", true);
            stockStorage.Add("E6", true);
            stockStorage.Add("E7", true);
            stockStorage.Add("E8", true);
            stockStorage.Add("E9", true);
            stockStorage.Add("E10", true);
            stockStorage.Add("F1", true);
            stockStorage.Add("F2", true);
            stockStorage.Add("F3", true);
            stockStorage.Add("F4", true);
            stockStorage.Add("F5", true);
            stockStorage.Add("F6", true);
            stockStorage.Add("F7", true);
            stockStorage.Add("F8", true);
            stockStorage.Add("F9", true);
            stockStorage.Add("F10", true);
            stockStorage.Add("G1", true);
            stockStorage.Add("G2", true);
            stockStorage.Add("G3", true);
            stockStorage.Add("G4", true);
            stockStorage.Add("G5", true);
            stockStorage.Add("G6", true);
            stockStorage.Add("G7", true);
            stockStorage.Add("G8", true);
            stockStorage.Add("G9", true);
            stockStorage.Add("G10", true);
            stockStorage.Add("H1", true);
            stockStorage.Add("H2", true);
            stockStorage.Add("H3", true);
            stockStorage.Add("H4", true);
            stockStorage.Add("H5", true);
            stockStorage.Add("H6", true);
            stockStorage.Add("H7", true);
            stockStorage.Add("H8", true);
            stockStorage.Add("H9", true);
            stockStorage.Add("H10", true);
            stockStorage.Add("I1", true);
            stockStorage.Add("I2", true);
            stockStorage.Add("I3", true);
            stockStorage.Add("I4", true);
            stockStorage.Add("I5", true);
            stockStorage.Add("I6", true);
            stockStorage.Add("I7", true);
            stockStorage.Add("I8", true);
            stockStorage.Add("I9", true);
            stockStorage.Add("I10", true);
            stockStorage.Add("J1", true);
            stockStorage.Add("J2", true);
            stockStorage.Add("J3", true);
            stockStorage.Add("J4", true);
            stockStorage.Add("J5", true);
            stockStorage.Add("J6", true);
            stockStorage.Add("J7", true);
            stockStorage.Add("J8", true);
            stockStorage.Add("J9", true);
            stockStorage.Add("J10", true);
            stockStorage.Add("K1", true);
            stockStorage.Add("K2", true);
            stockStorage.Add("K3", true);
            stockStorage.Add("K4", true);
            stockStorage.Add("K5", true);
            stockStorage.Add("K6", true);
            stockStorage.Add("K7", true);
            stockStorage.Add("K8", true);
            stockStorage.Add("K9", true);
            stockStorage.Add("K10", true);
            stockStorage.Add("L1", true);
            stockStorage.Add("L2", true);
            stockStorage.Add("L3", true);
            stockStorage.Add("L4", true);
            stockStorage.Add("L5", true);
            stockStorage.Add("L6", true);
            stockStorage.Add("L7", true);
            stockStorage.Add("L8", true);
            stockStorage.Add("L9", true);
            stockStorage.Add("L10", true);
            stockStorage.Add("M1", true);
            stockStorage.Add("M2", true);
            stockStorage.Add("M3", true);
            stockStorage.Add("M4", true);
            stockStorage.Add("M5", true);
            stockStorage.Add("M6", true);
            stockStorage.Add("M7", true);
            stockStorage.Add("M8", true);
            stockStorage.Add("M9", true);
            stockStorage.Add("M10", true);
            stockStorage.Add("N1", true);
            stockStorage.Add("N2", true);
            stockStorage.Add("N3", true);
            stockStorage.Add("N4", true);
            stockStorage.Add("N5", true);
            stockStorage.Add("N6", true);
            stockStorage.Add("N7", true);
            stockStorage.Add("N8", true);
            stockStorage.Add("N9", true);
            stockStorage.Add("N10", true);
            stockStorage.Add("O1", true);
            stockStorage.Add("O2", true);
            stockStorage.Add("O3", true);
            stockStorage.Add("O4", true);
            stockStorage.Add("O5", true);
            stockStorage.Add("O6", true);
            stockStorage.Add("O7", true);
            stockStorage.Add("O8", true);
            stockStorage.Add("O9", true);
            stockStorage.Add("O10", true);
            stockStorage.Add("P1", true);
            stockStorage.Add("P2", true);
            stockStorage.Add("P3", true);
            stockStorage.Add("P4", true);
            stockStorage.Add("P5", true);
            stockStorage.Add("P6", true);
            stockStorage.Add("P7", true);
            stockStorage.Add("P8", true);
            stockStorage.Add("P9", true);
            stockStorage.Add("P10", true);
            stockStorage.Add("Q1", true);
            stockStorage.Add("Q2", true);
            stockStorage.Add("Q3", true);
            stockStorage.Add("Q4", true);
            stockStorage.Add("Q5", true);
            stockStorage.Add("Q6", true);
            stockStorage.Add("Q7", true);
            stockStorage.Add("Q8", true);
            stockStorage.Add("Q9", true);
            stockStorage.Add("Q10", true);
            stockStorage.Add("R1", true);
            stockStorage.Add("R2", true);
            stockStorage.Add("R3", true);
            stockStorage.Add("R4", true);
            stockStorage.Add("R5", true);
            stockStorage.Add("R6", true);
            stockStorage.Add("R7", true);
            stockStorage.Add("R8", true);
            stockStorage.Add("R9", true);
            stockStorage.Add("R10", true);
            stockStorage.Add("S1", true);
            stockStorage.Add("S2", true);
            stockStorage.Add("S3", true);
            stockStorage.Add("S4", true);
            stockStorage.Add("S5", true);
            stockStorage.Add("S6", true);
            stockStorage.Add("S7", true);
            stockStorage.Add("S8", true);
            stockStorage.Add("S9", true);
            stockStorage.Add("S10", true);
            stockStorage.Add("T1", true);
            stockStorage.Add("T2", true);
            stockStorage.Add("T3", true);
            stockStorage.Add("T4", true);
            stockStorage.Add("T5", true);
            stockStorage.Add("T6", true);
            stockStorage.Add("T7", true);
            stockStorage.Add("T8", true);
            stockStorage.Add("T9", true);
            stockStorage.Add("T10", true);
            stockStorage.Add("U1", true);
            stockStorage.Add("U2", true);
            stockStorage.Add("U3", true);
            stockStorage.Add("U4", true);
            stockStorage.Add("U5", true);
            stockStorage.Add("U6", true);
            stockStorage.Add("U7", true);
            stockStorage.Add("U8", true);
            stockStorage.Add("U9", true);
            stockStorage.Add("U10", true);
            stockStorage.Add("V1", true);
            stockStorage.Add("V2", true);
            stockStorage.Add("V3", true);
            stockStorage.Add("V4", true);
            stockStorage.Add("V5", true);
            stockStorage.Add("V6", true);
            stockStorage.Add("V7", true);
            stockStorage.Add("V8", true);
            stockStorage.Add("V9", true);
            stockStorage.Add("V10", true);
            stockStorage.Add("W1", true);
            stockStorage.Add("W2", true);
            stockStorage.Add("W3", true);
            stockStorage.Add("W4", true);
            stockStorage.Add("W5", true);
            stockStorage.Add("W6", true);
            stockStorage.Add("W7", true);
            stockStorage.Add("W8", true);
            stockStorage.Add("W9", true);
            stockStorage.Add("W10", true);
            stockStorage.Add("X1", true);
            stockStorage.Add("X2", true);
            stockStorage.Add("X3", true);
            stockStorage.Add("X4", true);
            stockStorage.Add("X5", true);
            stockStorage.Add("X6", true);
            stockStorage.Add("X7", true);
            stockStorage.Add("X8", true);
            stockStorage.Add("X9", true);
            stockStorage.Add("X10", true);
            stockStorage.Add("Y1", true);
            stockStorage.Add("Y2", true);
            stockStorage.Add("Y3", true);
            stockStorage.Add("Y4", true);
            stockStorage.Add("Y5", true);
            stockStorage.Add("Y6", true);
            stockStorage.Add("Y7", true);
            stockStorage.Add("Y8", true);
            stockStorage.Add("Y9", true);
            stockStorage.Add("Y10", true);
            stockStorage.Add("Z1", true);
            stockStorage.Add("Z2", true);
            stockStorage.Add("Z3", true);
            stockStorage.Add("Z4", true);
            stockStorage.Add("Z5", true);
            stockStorage.Add("Z6", true);
            stockStorage.Add("Z7", true);
            stockStorage.Add("Z8", true);
            stockStorage.Add("Z9", true);
            stockStorage.Add("Z10", true);
        }

        public Dictionary<string, bool> GetStorage()
        {
            return stockStorage;
        }

    }
}
