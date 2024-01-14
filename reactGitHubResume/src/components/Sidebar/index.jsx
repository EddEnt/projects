import { Link } from 'react-router-dom'
import './index.scss'
import Logo from '../../assets/images/logoInitials.jpg'

const Sidebar = () => (
    <div className='navBarLeft'>
        <Link className='logo' to='/'>
            <img src={Logo} alt="logo" />
        </Link>
    </div>
)

export default Sidebar