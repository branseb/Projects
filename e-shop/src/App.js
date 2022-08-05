import { useState } from 'react';
import './App.css';
import Product from './product';

function App() {

  const [cart, setCart] = useState([]);

  const hendler = function (product) {
    const newCart = [...cart]
    console.log(product)
    newCart.push(product)
    console.log(newCart)
    setCart(newCart)
  }

  const data = [
    {
      id: 1,
      productName: "Iphone 12",
      price: 850
    },
    {
      id: 2,
      productName: "Iphone 12 Pro",
      price: 1000
    },
    {
      id: 3,
      productName: "Iphone 12 Pro Max",
      price: 1250
    },
    {
      id: 4,
      productName: "Apple Watch 7",
      price: 500
    }

  ]

  return (
    <div className="App">
      {"Shopping card : " + cart.length + " item"}
      {data.map(item => <Product key={item.id} product={item} onClick={hendler} />)}
    </div>
  )
}

export default App;
