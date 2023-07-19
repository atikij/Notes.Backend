using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteList;

public class GetNoteListValidator : AbstractValidator<GetNoteListQuery>
{
    public GetNoteListValidator()
    {
        RuleFor(x => x.UserId).NotEqual(Guid.Empty);
    }
}