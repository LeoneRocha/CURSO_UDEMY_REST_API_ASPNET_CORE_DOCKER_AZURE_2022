import React, {  useState } from 'react';
import { Link,  useParams } from 'react-router-dom';
import { FiArrowLeft } from 'react-icons/fi'

//import api from '../../services/api';

import './styles.css';

import logoImage from '../../../assets/logo.svg';

export default function NewBook(){
  
    const [author, setAuthor] = useState('');
    const [title, setTitle] = useState('');
    const [launchDate, setLaunchDate] = useState('');
    const [price, setPrice] = useState('');  
    const { bookId } = useParams(); 
    return (
        <div className="new-book-container">
            <div className="content">
                <section className="form">
                    <img src={logoImage} alt="Erudio"/>
                    <h1>{1 === '0'? 'Add New' : 'Update'} Book</h1>
                    <p>Enter the book information and click on {1 === '0'? `'Add'` : `'Update'`}!</p>
                    <Link className="back-link" to="/books">
                        <FiArrowLeft size={16} color="#251fc5"/>
                        Back to Books
                    </Link>
                </section>
                
                <form  >
                    <input 
                        placeholder="Title"
                        value={title}
                        onChange={e => setTitle(e.target.value)}
                    />
                    <input 
                        placeholder="Author"
                        
                        value={author}
                        onChange={e => setAuthor(e.target.value)}
                    />
                    <input 
                        type="date"
                        
                        value={launchDate}
                        onChange={e => setLaunchDate(e.target.value)}
                    />
                    <input 
                        placeholder="Price"
                        
                        value={price}
                        onChange={e => setPrice(e.target.value)}
                    />

                    <button className="button" type="submit">{bookId === '0'? 'Add' : 'Update'}</button>
                </form>
 
            </div>
        </div>
    );
}