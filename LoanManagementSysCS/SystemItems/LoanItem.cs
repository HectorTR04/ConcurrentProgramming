using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanManagementSys.SystemItems;

/// <summary>
/// Class that represents a loan item. Each loan item has an object of the
/// Product class and an object of the Member class.  The member is the
/// object that loans the product. 
/// <summary>

public class LoanItem
{
    //Properties
    private Product product;
    private Member member;

    public LoanItem(Product product, Member member)
    {
        this.product = product;
        this.member = member;
    }
    public Product Product
    {
        get { return product; }
        set { product = value; }
    }

    public Member Member
    {
        get { return member; }
        set { member = value; }
    }

    //The toString method returning a textual representation of the object's values.
    public override string ToString()
    {
        string? memberStr = member != null ? "Loaned to  " + member.ToString() : string.Empty;
        return $"{product.ToString(), -15} {memberStr}";
    }
}



