// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IResignationVerificationScrudViewRepository
    {
        /// <summary>
        /// Performs count on IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IResignationVerificationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ResignationVerificationScrudView" class from IResignationVerificationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ResignationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationVerificationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IResignationVerificationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ResignationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationVerificationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ResignationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationVerificationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ResignationVerificationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ResignationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationVerificationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ResignationVerificationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IResignationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ResignationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationVerificationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}