import { Component, Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class FooService {

  baseURL: string
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  get() {
    return this.http.get<Foo[]>(this.baseURL + 'foos');
  }
}

export interface Foo {
  id: string;
  col1: string;
  col2: number;
  col3: number;
  col4: number;
}
