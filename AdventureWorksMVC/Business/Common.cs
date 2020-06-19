
namespace AdventureWorks.Business
{
    /// <summary>
    /// Contains common helper methods and properties used in this application.
    /// </summary>
    public class Common
    {
        /// <summary>
        /// Gets the data entities.
        /// </summary>
        /// <value>The data entities.</value>
        public static CYCLE_STOREEntities DataEntities
        {
            get
            {
                return new CYCLE_STOREEntities();
            }
        }
    }
}