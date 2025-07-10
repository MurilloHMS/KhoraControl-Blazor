using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl;

public class UserPolicy
{
    public const string VIEW_PRODUCT = "VIEW_PRODUCT";
    public const string CREATE_PRODUCT = "CREATE_PRODUCT";
    public const string UPDATE_PRODUCT = "UPDATE_PRODUCT";
    public const string DELETE_PRODUCT = "DELETE_PRODUCT";

    public static List<string> GetPolicies()
    {
        return new List<string>
        {
            VIEW_PRODUCT,
            CREATE_PRODUCT,
            UPDATE_PRODUCT,
            DELETE_PRODUCT
        };
    }
}
