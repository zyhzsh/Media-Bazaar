
<?php
class Session
{
    const SESSION_STARTED = TRUE;
    const SESSION_NOT_STARTED = FALSE;
   
    // The state of the session
    private $sessionState = self::SESSION_NOT_STARTED;
   
    // THE only instance of the class
    private static $instance;
   
   
    private function __construct() {}
   
   
    /**
    *    Returns THE instance of 'Session'.
    *    The session is automatically initialized if it wasn't.
    *   
    *    @return    object
    **/
   
    public static function getInstance()
    {
        if ( !isset(self::$instance))
        {
            self::$instance = new self;
        }
       
        self::$instance->startSession();
       
        return self::$instance;
    }
   
   
    /**
    *    (Re)starts the session.
    *   
    *    @return    bool    TRUE if the session has been initialized, else FALSE.
    **/
   
    public function startSession()
    {
        if ( $this->sessionState == self::SESSION_NOT_STARTED )
        {
            $this->sessionState = session_start();
        }
       
        return $this->sessionState;
    }
   
   
    public function __set( $name , $value )
    {
        $_SESSION[$name] = $value;
         //temporary code here, decided later
         //We assume the server's date and user's date are same.
         //When user login to this page, haven't Selet the date on Calendar, We set default value="Today";
        $_SESSION['SeletedDate']=date("Y-m-1");
    }
    
    public  function __get( $name )
    {
        if ( isset($_SESSION[$name]))
        {
            return $_SESSION[$name];
        }else{
            return null;
        }
    }
   
   
    public function __isset( $name )
    {
        return isset($_SESSION[$name]);
    }
   
   
    public function __unset( $name )
    {
        unset( $_SESSION[$name] );
    }
}
    ?>