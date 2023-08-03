Partial views stored in `views/shared`, by convention name starts with `_`.

Using in another view:
```cshtml
@Html.Partial("_PartialViewName")
```
By default whole model passed to partial view Pass model:
```cshtml
@Html.Partial("_PartialViewName", )
```