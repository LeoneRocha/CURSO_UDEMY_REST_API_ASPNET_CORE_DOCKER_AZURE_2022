import React from 'react';
import { BrowserRouter, Route,  Routes as RoutesB  } from 'react-router-dom';
import Login from './pages/Login';
import Book from './pages/Book';
import NewBook from './pages/Book/NewBook';

export default function Routes() {
    return (
        <BrowserRouter>
            <RoutesB>
                <Route exact path="/" element={<Login />}></Route>
                <Route path="/book" element={<Book />}></Route>
                <Route path="/book/new" element={<NewBook />}></Route>

            </RoutesB>
        </BrowserRouter>
    );
}