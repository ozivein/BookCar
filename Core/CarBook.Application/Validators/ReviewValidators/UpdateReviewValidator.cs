using FluentValidation;
using UdemyCarBook.Application.Features.Mediator.Commands;

namespace UdemyCarBook.Application.Validators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeniyiz");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karekter veri girişi yapınız");
            RuleFor(x => x.ReytingValue).NotEmpty().WithMessage("Lütfen Puan Değerini boş geçmeyiniz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen Yorum Değerini boş geçmeyiniz");
            RuleFor(x => x.Comment).MinimumLength(50).WithMessage("Lütfen Yorum kısmına en az 50 karekter veri girişi yapınız");
            RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen Yorum kısmına en fazla 500 karekter veri girişi yapınız");
            RuleFor(x => x.CustomerImage).NotEmpty().WithMessage("Lüten Müşteri görselini boş geçmeyiniz").MinimumLength(10).WithMessage("Lütfen En az 10 karekter veri girişi yapınız").MaximumLength(200).WithMessage("En fazla 200 karekter veri girişi yazınız");
        }
    }
}
