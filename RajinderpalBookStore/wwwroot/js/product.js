﻿@model[YourBookStore].Models.ViewModels.ProductVM

@{
    Layout = "~/Views/Shared/_Layout.cshtml";
    var title = "Create Product";
}

<form method="post" enctype="multipart/form-data">
    <div class="row p-3 border">
        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
        @if(Model.Product.Id != 0)       // if this value is null it will not display 'Edit Category', change to  0
        {
            // edit 
            title = "Edit Product";
            <input type="hidden" asp-for="Product.Id" />
        }
        <div class="col-12 border-bottom">
            <h2 class="text-primary">@title</h2>
        </div>
        <div class="col-8 pt-4">
            <div class="form-group row">
                <div class="col-4">
                    <label asp-for="Product.Title"></label>
                </div>
                <div class="col-8">
                    <input asp-for="Product.Title" class="form-control" />
                    <span asp-validation-for="Product.Title" class="text-danger"></span>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    <label asp-for="Product.ISBN"></label>
                </div>
                <div class="col-8">
                    <input asp-for="Product.ISBN" class="form-control" />
                    <span asp-validation-for="Product.ISBN" class="text-danger"></span>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    <label asp-for="Product.Author"></label>
                </div>
                <div class="col-8">
                    <input asp-for="Product.Author" class="form-control" />
                    <span asp-validation-for="Product.Author" class="text-danger"></span>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    <label asp-for="Product.Description"></label>
                </div>
                <div class="col-8">
                    <textarea asp-for="Product.Description" class="form-control"></textarea>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    <label asp-for="Product.ListPrice"></label>
                </div>
                <div class="col-8">
                    <input asp-for="Product.ListPrice" class="form-control" />
                    <span asp-validation-for="Product.ListPrice" class="text-danger"></span>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    Category
                </div>
                <div class="col-8">
                    @Html.DropDownListFor(m => m.Product.CategoryId, Model.CategoryList, "-Select a Category",
                   new { @class = "form-control" })
                    <span asp-validation-for="Product.CategoryId" class="text-danger"></span>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    Cover Type
                </div>
                <div class="col-8">
                    @Html.DropDownListFor(m => m.Product.CategoryId, Model.CategoryList, "-Select a Cover Type",
                   new { @class = "form-control" })
                    <span asp-validation-for="Product.CoverTypeId" class="text-danger"></span>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    Image
                </div>
                <div class="col-8">
                    <input type="file" name="files" id="uploadBox" multiple class="form-control" />
                </div>
            </div>
            <div class="form-group row">
                <div class="col-8 offset-4">
                    @if (Model.Product.Id != 0)
                    {
                        <partial name="_EditAndBackToListButton" model="Model.Product.Id" />
                    }
                    else
                    {
                        <div class="row">
                            <div class="col">
                                <button type="submit" onclick="return validateInput()" class="btn btn-primary form-control">Create</button>
                            </div>
                            <div class="col">
                                <a asp-action="Index" class="btn btn-success form-control">Back to List</a>
                            </div>
                        </div>
                    }
                </div>
            </div>
        </div>
    </div>
</form>

@section Scripts {
    <partial name="_ValidationScriptsPartial" />
}