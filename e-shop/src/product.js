import { useState } from 'react';

function Product({product,onClick}) {

    const [isincart, setIsInCart] = useState(false);

    
    return (
        <div className="product">
            <h2>{product.productName}</h2>
            <div>{product.price} Eur </div>
            <div>{isincart && "In Cart"}</div>
            <button onClick={() =>{
                setIsInCart (true);
                onClick(product)}}>Buy</button>
        </div>
    )
}
export default Product;