import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class PizzasDataService {
  _url = 'https://localhost:44366/';
  constructor(private http: HttpClient, private httpParams: HttpParams) {}

  getOrderPizzaData() {
    return this.http.get(this._url + 'Pizza/Pizza');
  }
  getBuildPizzaData() {
    return this.http.get(this._url + 'Ingredients/Ingredients');
  }
  getCartData(email: any) {
    let params = new HttpParams();
    params = params.append('email', email);
    return this.http.get(this._url + 'CartItem/GetCartContents', { params });
  }
  updateCartData(cart: any) {
    return this.http.put(
      this._url + 'CartItem/UpdateCartContents',
      {
        email: cart.Email,
        pizzaOption: cart.PizzaOption,
        pizzaIngredients: cart.PizzaIngredients,
      },
      {}
    );
  }
  deleteCartItem(id: any) {
    let params = new HttpParams();
    params = params.append('_id', id);
    return this.http.delete(this._url + 'cart', { params });
  }
}
