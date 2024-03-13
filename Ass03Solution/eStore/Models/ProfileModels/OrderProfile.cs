using AutoMapper;
using eStore.Models.DataModels;
using eStore.Models.ViewModels;

namespace eStore.Models.ProfileModels
{
	public class OrderProfile : Profile
	{
		public OrderProfile()
		{
			CreateMap<OrderViewModel, Order>();
		}
	}
}
