# W04 Team Activity: Foundation Programs Design


## Online Ordering
Order -> Customer -> Address
Order -> Product

- **Order**: products, customer | AddProduct, CalculateTotal, MakeLabels
- **Product**: name, price, quantity | CalculateTotalCost
- **Customer**: name, address | GetShippingLabel
- **Address**: street, city, state, country | IsInUSA

## YouTube Videos
Video -> Comment

- **Video**: title, author, length, comments | AddComment, GetCommentCount
- **Comment**: name, text