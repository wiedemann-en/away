import { INavData } from '@coreui/angular';

export const navItems: INavData[] = [
  {
    name: 'Dashboard',
    url: '/dashboard',
    icon: 'icon-speedometer',
    badge: {
      variant: 'info',
      text: 'ME'
    }
  },
  {
    title: true,
    name: 'Datos'
  },
  {
    name: 'Seguridad',
    url: '/core',
    icon: 'icon-star',
    children: [
      {
        name: 'Usuarios',
        url: '/core/usuarios',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Roles',
        url: '/core/roles',
        // icon: 'icon-puzzle'
      },
    ]
  },
  {
    name: 'Datos Generales',
    url: '/core',
    icon: 'icon-star',
    children: [
      {
        name: 'Alicuotas IVA',
        url: '/core/alicuotasiva',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Condiciones de Pago',
        url: '/core/condicionespago',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Tipos Documento',
        url: '/core/documento-tipos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Tipos Domicilio',
        url: '/core/domicilio-tipos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Paises',
        url: '/core/paises',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Provincias',
        url: '/core/provincias',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Partidos',
        url: '/core/partidos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Localidades',
        url: '/core/localidades',
        // icon: 'icon-puzzle'
      },
    ]
  },
  {
    name: 'Articulos',
    url: '/core',
    icon: 'icon-star',
    children: [
      {
        name: 'Articulos',
        url: '/core/articulos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Categorias',
        url: '/core/articulo-categorias',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Lineas',
        url: '/core/articulo-lineas',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Marcas',
        url: '/core/articulo-marcas',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Rubros',
        url: '/core/articulo-rubros',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Tipos',
        url: '/core/articulo-tipos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Subtipos',
        url: '/core/articulo-subtipos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Uni Medidas',
        url: '/core/articulo-unidad-medida',
        // icon: 'icon-puzzle'
      },
    ]
  },
  {
    name: 'Clientes',
    url: '/core',
    icon: 'icon-star',
    children: [
      {
        name: 'Clientes',
        url: '/core/clientes',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Rubros',
        url: '/core/cliente-rubros',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Categorias',
        url: '/core/cliente-categorias',
        // icon: 'icon-puzzle'
      },
      {
        name: 'Tipos',
        url: '/core/cliente-tipos',
        // icon: 'icon-puzzle'
      },
      {
        name: 'SubTipos',
        url: '/core/cliente-subtipos',
        // icon: 'icon-puzzle'
      },
    ]
    },
  // {
  //   title: true,
  //   name: 'Theme'
  // },
  // {
  //   name: 'Colors',
  //   url: '/theme/colors',
  //   icon: 'icon-drop'
  // },
  // {
  //   name: 'Typography',
  //   url: '/theme/typography',
  //   icon: 'icon-pencil'
  // },
  // {
  //   title: true,
  //   name: 'Components'
  // },
  // {
  //   name: 'Base',
  //   url: '/base',
  //   icon: 'icon-puzzle',
  //   children: [
  //     {
  //       name: 'Cards',
  //       url: '/base/cards',
  //       icon: 'icon-puzzle'
  //     },
     
  //   ]
  // },
  // {
  //   divider: true
  // },
  // {
  //   title: true,
  //   name: 'Extras',
  // },
  // {
  //   name: 'Pages',
  //   url: '/pages',
  //   icon: 'icon-star',
  //   children: [
  //     {
  //       name: 'Login',
  //       url: '/login',
  //       icon: 'icon-star'
  //     },
  //     {
  //       name: 'Register',
  //       url: '/register',
  //       icon: 'icon-star'
  //     },
  //     {
  //       name: 'Error 404',
  //       url: '/404',
  //       icon: 'icon-star'
  //     },
  //     {
  //       name: 'Error 500',
  //       url: '/500',
  //       icon: 'icon-star'
  //     }
  //   ]
  // },
  // {
  //   name: 'Disabled',
  //   url: '/dashboard',
  //   icon: 'icon-ban',
  //   badge: {
  //     variant: 'secondary',
  //     text: 'NEW'
  //   },
  //   attributes: { disabled: true },
  // },

  // {
  //   name: 'Download CoreUI',
  //   url: 'http://coreui.io/angular/',
  //   icon: 'icon-cloud-download',
  //   class: 'mt-auto',
  //   variant: 'success',
  //   attributes: { target: '_blank', rel: 'noopener' }
  // },
  // {
  //   name: 'Try CoreUI PRO',
  //   url: 'http://coreui.io/pro/angular/',
  //   icon: 'icon-layers',
  //   variant: 'danger',
  //   attributes: { target: '_blank', rel: 'noopener' }
  // }
];
