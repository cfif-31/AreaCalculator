SELECT Product.ProductName, Category.CategoryName
	FROM Product
LEFT OUTER JOIN ProductHasCategory
  	ON Product.ProductId = ProductHasCategory.ProductId
LEFT OUTER JOIN Category
  	ON ProductHasCategory.CategoryId = Category.CategoryId