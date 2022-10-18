﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Inspire.Erp.Application.Account.Interfaces;
using Inspire.Erp.Application.Common;
using Inspire.Erp.Domain.Entities;
using Inspire.Erp.Domain.Enums;
using Inspire.Erp.Web.Common;
using Inspire.Erp.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inspire.Erp.Web.Controllers
{
    [Route("api/payment")]
    [Produces("application/json")]
    [ApiController]
    public class PaymentVoucherController : ControllerBase
    {
        private IPaymentVoucherService _paymentVoucherService;
        private readonly IMapper _mapper;
        public PaymentVoucherController(IPaymentVoucherService paymentVoucherService, IMapper mapper)
        {
            _paymentVoucherService = paymentVoucherService;
            _mapper = mapper;
        }
        //[HttpPost]
        //[Route("InsertPaymentVoucher")]
        //public PaymentVoucherViewModel InsertPaymentVoucher([FromBody] PaymentVoucherCompositeView voucherCompositeView)
        //{
        //    List <PaymentVoucherDetailsViewModel> paymentVoucherDetailsViewModels = new List<PaymentVoucherDetailsViewModel>();
        //    var param1 = _mapper.Map<PaymentVoucher>(voucherCompositeView.PaymentVoucher);
        //    var param2 = _mapper.Map<List<PaymentVoucherDetails>>(voucherCompositeView.PaymentVoucherDetails);    
        //    var xs = _paymentVoucherService.InsertPaymentVoucher(param1, param2);
        //    return _mapper.Map<PaymentVoucherViewModel>(xs);

        //}

        [HttpPost]
        [Route("InsertPaymentVoucher")]
        public ApiResponse<PaymentVoucherViewModel> InsertPaymentVoucher([FromBody] PaymentVoucherViewModel voucherCompositeView)
        {
            ApiResponse<PaymentVoucherViewModel> apiResponse = new ApiResponse<PaymentVoucherViewModel>();
            if (_paymentVoucherService.GetVouchersNumbers(voucherCompositeView.PaymentVoucherVoucherNo) == null)
            {
                var param1 = _mapper.Map<PaymentVoucher>(voucherCompositeView);
                var param2 = _mapper.Map<List<PaymentVoucherDetails>>(voucherCompositeView.PaymentVoucherDetails);
                var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
                var xs = _paymentVoucherService.InsertPaymentVoucher(param1, param3, param2);
                PaymentVoucherViewModel paymentVoucherViewModel = new PaymentVoucherViewModel
                {
                    PaymentVoucherVoucherNo =   xs.paymentVoucher.PaymentVoucherVoucherNo,
                    PaymentVoucherCrAmount = xs.paymentVoucher.PaymentVoucherCrAmount,
                    PaymentVoucherCrAcNo = xs.paymentVoucher.PaymentVoucherCrAcNo,
                    PaymentVoucherDate = xs.paymentVoucher.PaymentVoucherDate,
                    PaymentVoucherSno = xs.paymentVoucher.PaymentVoucherSno,
                    PaymentVoucherNarration = xs.paymentVoucher.PaymentVoucherNarration,
                    PaymentVoucherCurrencyId = xs.paymentVoucher.PaymentVoucherCurrencyId,
                    PaymentVoucherVoucherRef = xs.paymentVoucher.PaymentVoucherVoucherRef,
                    PaymentVoucherDbAmount = xs.paymentVoucher.PaymentVoucherDbAmount
                };

                paymentVoucherViewModel.PaymentVoucherDetails = _mapper.Map<List<PaymentVoucherDetailsViewModel>>(xs.paymentsVoucherDetails);
                paymentVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(xs.accountsTransactions);
                apiResponse = new ApiResponse<PaymentVoucherViewModel>
                {
                    Valid = true,
                    Result = _mapper.Map<PaymentVoucherViewModel>(paymentVoucherViewModel),
                    Message = PaymentVoucherMessage.SaveVoucher
                };
            }
            else
            {
                apiResponse = new ApiResponse<PaymentVoucherViewModel>
                {
                    Valid = false,
                    Error = true,
                    Exception = null,
                    Message = PaymentVoucherMessage.VoucherAlreadyExist
                };

            }
       

            return apiResponse;

        }

        [HttpPost]
        [Route("UpdatePaymentVoucher")]
        public ApiResponse<PaymentVoucherViewModel> UpdatePaymentVoucher([FromBody] PaymentVoucherViewModel voucherCompositeView)
        {
            var param1 = _mapper.Map<PaymentVoucher>(voucherCompositeView);
            var param2 = _mapper.Map<List<PaymentVoucherDetails>>(voucherCompositeView.PaymentVoucherDetails);
            var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
            var xs = _paymentVoucherService.UpdatePaymentVoucher(param1, param3, param2);

            PaymentVoucherViewModel paymentVoucherViewModel = new PaymentVoucherViewModel
            {
                PaymentVoucherVoucherNo = xs.paymentVoucher.PaymentVoucherVoucherNo,
                PaymentVoucherCrAmount = xs.paymentVoucher.PaymentVoucherCrAmount,
                PaymentVoucherCrAcNo = xs.paymentVoucher.PaymentVoucherCrAcNo,
                PaymentVoucherDate = xs.paymentVoucher.PaymentVoucherDate,
                PaymentVoucherSno = xs.paymentVoucher.PaymentVoucherSno,
                PaymentVoucherNarration = xs.paymentVoucher.PaymentVoucherNarration,
                PaymentVoucherCurrencyId = xs.paymentVoucher.PaymentVoucherCurrencyId,
                PaymentVoucherVoucherRef = xs.paymentVoucher.PaymentVoucherVoucherRef,
                PaymentVoucherDbAmount = xs.paymentVoucher.PaymentVoucherDbAmount
            };

            paymentVoucherViewModel.PaymentVoucherDetails = _mapper.Map<List<PaymentVoucherDetailsViewModel>>(xs.paymentsVoucherDetails);
            paymentVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(xs.accountsTransactions);
            ApiResponse<PaymentVoucherViewModel> apiResponse = new ApiResponse<PaymentVoucherViewModel>
            {
                Valid = true,
                Result = _mapper.Map<PaymentVoucherViewModel>(paymentVoucherViewModel),
                Message = PaymentVoucherMessage.UpdateVoucher
            };

            return apiResponse;
        }

        [HttpPost]
        [Route("DeletePaymentVoucher")]
        public ApiResponse<int> DeletePaymentVoucher([FromBody] PaymentVoucherViewModel voucherCompositeView)
        {
            var param1 = _mapper.Map<PaymentVoucher>(voucherCompositeView);
            var param2 = _mapper.Map<List<PaymentVoucherDetails>>(voucherCompositeView.PaymentVoucherDetails);
            var param3 = _mapper.Map<List<AccountsTransactions>>(voucherCompositeView.AccountsTransactions);
            var xs = _paymentVoucherService.DeletePaymentVoucher(param1, param3, param2);
            ApiResponse<int> apiResponse = new ApiResponse<int>
            {
                Valid = true,
                Result = 0,
                Message = PaymentVoucherMessage.DeleteVoucher
            };

            return apiResponse;

        }

        [HttpGet]
        [Route("GetAllAccountTransaction")]
        public ApiResponse<List<AccountsTransactions>> GetAllAccountTransaction()
        {
            ApiResponse<List<AccountsTransactions>> apiResponse = new ApiResponse<List<AccountsTransactions>>
            {
                Valid = true,
                Result = _mapper.Map<List<AccountsTransactions>>(_paymentVoucherService.GetAllTransaction()),
                Message = ""
            };
            return apiResponse;
        }

        [HttpGet]
        [Route("GetPaymentVouchers")]
        public ApiResponse<List<PaymentVoucher>> GetAllPayments()
        {
            ApiResponse<List<PaymentVoucher>> apiResponse = new ApiResponse<List<PaymentVoucher>>
            {
                Valid = true,
                Result = _mapper.Map<List<PaymentVoucher>>(_paymentVoucherService.GetPaymentVouchers()),
                Message = ""
            };
            return apiResponse;
        }

        [HttpGet]
        [Route("GetSavedPaymentDetails/{id}")]
        public ApiResponse<PaymentVoucherViewModel> GetSavedPaymentDetails(string id)
        {
            PaymentVoucherModel paymentVoucher = _paymentVoucherService.GetSavedPaymentDetails(id);
            if(paymentVoucher != null)
            {
                PaymentVoucherViewModel paymentVoucherViewModel = new PaymentVoucherViewModel
                {
                    PaymentVoucherVoucherNo = paymentVoucher.paymentVoucher.PaymentVoucherVoucherNo,
                    PaymentVoucherCrAmount = paymentVoucher.paymentVoucher.PaymentVoucherCrAmount,
                    PaymentVoucherCrAcNo = paymentVoucher.paymentVoucher.PaymentVoucherCrAcNo,
                    PaymentVoucherDate = paymentVoucher.paymentVoucher.PaymentVoucherDate,
                    PaymentVoucherSno = paymentVoucher.paymentVoucher.PaymentVoucherSno,
                    PaymentVoucherNarration = paymentVoucher.paymentVoucher.PaymentVoucherNarration,
                    PaymentVoucherCurrencyId = paymentVoucher.paymentVoucher.PaymentVoucherCurrencyId,
                    PaymentVoucherVoucherRef = paymentVoucher.paymentVoucher.PaymentVoucherVoucherRef,
                    PaymentVoucherDbAmount = paymentVoucher.paymentVoucher.PaymentVoucherDbAmount
                };
                paymentVoucherViewModel.PaymentVoucherDetails = _mapper.Map<List<PaymentVoucherDetailsViewModel>>(paymentVoucher.paymentsVoucherDetails);
                paymentVoucherViewModel.AccountsTransactions = _mapper.Map<List<AccountTransactionsViewModel>>(paymentVoucher.accountsTransactions);
                ApiResponse<PaymentVoucherViewModel> apiResponse = new ApiResponse<PaymentVoucherViewModel>
                {
                    Valid = true,
                    Result = paymentVoucherViewModel,
                    Message = ""
                };
                return apiResponse;
            }
            return null;
       
        }

        [HttpGet]
        [Route("CheckVnoExist/{id}")]
        public ApiResponse<bool> CheckVnoExist(string id)
        {
            ApiResponse<bool> apiResponse = new ApiResponse<bool>
            {
                Valid = true,
                Result = true,
                Message = PaymentVoucherMessage.VoucherAlreadyExist
            };
            var x = _paymentVoucherService.GetVouchersNumbers(id);
            if(x == null)
            {
                apiResponse.Result = false;
                apiResponse.Message = "";
            }
          
            return apiResponse;
        }
    }
}