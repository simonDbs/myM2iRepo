import React,{useState} from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import './NavBarComponent.css';
import HomeView from '../../views/HomeView/HomeView';
import ContactListView from '../../views/ContactListView/ContactListView';
import AddContactView from '../../views/AddContactView/AddContactView';
import { contactListe } from '../../datas/ContactList';


const NavBarComponent = () => {
    const [contactList,setContactList] = useState(contactListe)
    return (
        <div>
            <BrowserRouter>
                <div id="NavBar">
                    <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/list">Contact List</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/addPerson">Add Contact</Link>
                    </button>
                </div>
                <Routes>
                    <Route path="/" element={<HomeView />} />                  
                    <Route path="/list" element={<ContactListView contactList={contactList} setContactList={setContactList}/>} />
                    <Route path="/addPerson" element={<AddContactView contactList={contactList} setContactList={setContactList}/>} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div>
    );
}

export default NavBarComponent;
