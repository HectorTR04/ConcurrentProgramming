using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanManagementSys.SystemItems;

namespace LoanManagementSys.Managers
{
    /// <summary>
    /// Manager which takes care of adding and removing LoanItems and creating 
    /// info strings to display the LoanItems's data
    /// </summary>
    public class LoanItemManager : BaseManager<LoanItem>
    {
        ProductManager productManager; //Reference to the ProductManager class to access Product data
        MemberManager memberManager; //Reference to the MemberManager class to access Member data
        Random random = new Random();//A system random used to generate a product and member for LoanItem creation

        public LoanItemManager(ProductManager productManager, MemberManager memberManager)
        {
            this.productManager = productManager;
            this.memberManager = memberManager;
        }

        /// <summary>
        /// Method which randomly generates a product and member from the Product and Member Lists.
        /// Adds a new LoanItem using the selected product and member to the list of LoanItems.
        /// Removes the selected product from the product list so that it can not be borrowed again until returned.
        /// </summary>
        public void AddLoanItem()
        {
            int randomProduct = random.Next(0,productManager._systemItems.Count); //Random product from product list
            int randomMember = random.Next(0, memberManager._systemItems.Count); //Random member from member list
            
            Product product = productManager._systemItems[randomProduct];
            Member member = memberManager._systemItems[randomMember];

            CreateLoanItem(product, member); //Call to the CreateLoanItem method to create a loan item and add to list
            productManager.Remove(product); //Removes the selected product from the product list
        }

        /// <summary>
        /// Method to remove a LoanItems from the LoanItems list (return the product from loan).
        /// Adds the product which was part of the removed LoanItem back to the products list.
        /// Randomly generates which LoanItem to remove.
        /// </summary>
        public void RemoveLoanItem()
        {
            if (_systemItems.Count == 0) //If there are no LoanItems skip running the method
            {
                return;
            }
            int randomIndex = random.Next(0, _systemItems.Count); //Randomly generated LoanItem to remove

            LoanItem loanItem = _systemItems[randomIndex];

            if (_systemItems.Contains(loanItem)) //If the LoanItem is in the list
            {                                    
                productManager._systemItems.Add(loanItem.Product); //Add product back to product list
                _systemItems.Remove(loanItem); //Remove LoanItem from LoanItem list
            }
        }

        //Method which returns a LoanItem object using a combination of a product and member.       
        public LoanItem CreateLoanItem(Product product, Member member)
        {
            LoanItem loanItem = new LoanItem(product, member);
            loanItem.Member = member;
            loanItem.Product = product;
            _systemItems.Add(loanItem);
            return loanItem;
        }

        //Method which creates an array of strings to display information about which products are currently on loan.        
        public String[] GetLoanItemInfoStrings()
        {
            //Create an array with enough space to accommodate the number of products available and the item strings
            string[] infoStrings = new string[_systemItems.Count + 1];

            //First string displays the amount of products currently on loan
            infoStrings[0] = $"Products on loan: {_systemItems.Count}";

            //Fill the array with item strings displaying the LoanItem's data 
            for (int i = 0; i < _systemItems.Count; i++)
            {
                infoStrings[i + 1] = _systemItems[i].ToString();
            }
            //Return the array of infoStrings
            return infoStrings;
        }
    }
}
