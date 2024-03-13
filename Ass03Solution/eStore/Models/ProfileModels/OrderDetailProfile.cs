using AutoMapper;
using eStore.Models.DataModels;
using eStore.Models.ViewModels;

namespace eStore.Models.ProfileModels
{
	public class OrderDetailProfile : Profile
	{
		public OrderDetailProfile()
		{
			CreateMap<OrderDetailViewModel, OrderDetail>();
		}
	}
}
