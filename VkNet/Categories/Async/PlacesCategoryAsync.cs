using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkNet.Model.RequestParams;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PlacesCategory
	{
		/// <inheritdoc />
		public Task<long> AddAsync(PlacesAddParams placesAddParams)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>Add(placesAddParams: placesAddParams));
		}

		/// <inheritdoc />
		public Task<object> CheckinAsync(PlacesCheckinParams placesCheckinParams)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>Checkin(placesCheckinParams: placesCheckinParams));
		}

		/// <inheritdoc />
		public Task<IEnumerable<object>> GetByIdAsync(IEnumerable<ulong> places)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>GetById(places: places));
		}

		/// <inheritdoc />
		public Task<IEnumerable<object>> GetCheckinsAsync(PlacesGetCheckinsParams placesGetCheckinsParams)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>
				GetCheckins(placesGetCheckinsParams: placesGetCheckinsParams));
		}

		/// <inheritdoc />
		public Task<IEnumerable<object>> GetTypesAsync()
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>GetTypes());
		}

		/// <inheritdoc />
		public Task<Uri> SearchAsync(PlacesSearchParams placesSearchParams)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>Search(placesSearchParams: placesSearchParams));
		}
	}
}