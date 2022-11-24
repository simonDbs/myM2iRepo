import React , { useState } from 'react';
import { contactListe } from '../../datas/ContactList';
import Contact from '../../module/contact'

const AddContactView = () => {


    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');


    const [theArray, setTheArray] = useState(contactListe);
    console.log(theArray)
    // theArray.push()
    const tmp = new Contact(nom,prenom,telephone,email)
     
     
       const test = theArray.push(new Contact(nom,prenom,telephone,email));
       console.log(test)

    return (
        <div>
        <h2>Les Formulaires d'ajouts de contacts</h2>
        <div className="card">
            <form >
                <div className="form-control">
                    <div className="mb-3">
                        <label htmlFor="nom">Nom : </label>
                        <input type="text" name="nom" id="nom" className='form-control' onChange={(e) => setNom(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom">Prénom : </label>
                        <input type="text" name="prenom" id="prenom" className='form-control' onChange={(e) => setPrenom(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom">Email : </label>
                        <input type="text" name="email" id="email" className='form-control' onChange={(e) => setEmail(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom">Telephone : </label>
                        <input type="text" name="telephone" id="telephone" className='form-control' onChange={(e) => setTelephone(e.target.value)} />
                    </div>

                </div>
                <button type="submit" className='btn btn-secondary form-control' onSubmit={(e) => theArray.push(new Contact(nom,prenom,telephone,email))}>Valider</button>
            </form>
        </div>
    </div>
    );
}

export default AddContactView;
